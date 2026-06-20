using ZapC.CSharp.Generator.Tests;
using Microsoft.Build.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace ZapC.CSharp.MsBuild.Generation.Tests
{
    [TestClass]
    public class GenerateZapFileCodeBehindTaskTest
    {
        string LoadResourceContent(string name)
        {
            using (var stream = CodeGeneratorSteps.LoadResource("UnitTest1.zap"))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        [TestMethod]
        public void ExecutionWithoutParameters()
        {
            var task = new GenerateZapFileCodeBehindTask();
            task.BuildEngine = new BuildEngineMock();
            task.Execute();
            // Should not crash. Should Execute() return true or false if there is no input?
        }

        [TestMethod]
        public void SimpleGeneration()
        {
            string zapFile = "UnitTask1.zap";
            string content = LoadResourceContent(zapFile);
            string tmpPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tmpPath);
            string zapPath = Path.Combine(tmpPath, zapFile);
            File.WriteAllText(zapPath, content);

            var task = new GenerateZapFileCodeBehindTask();
            task.BuildEngine = new BuildEngineMock();
            task.ProjectPath = Path.Combine(tmpPath, "doesnotneedtoexist.csproj");
            task.ZapFiles = new ITaskItem[1] { new TaskItemMock() { ItemSpec = zapPath } };
            Assert.IsTrue(task.Execute());
            Assert.IsNotNull(task.GeneratedFiles);
            Assert.AreEqual(1, task.GeneratedFiles.Length);
            string csPath = Path.Combine(tmpPath, task.GeneratedFiles[0].ItemSpec);
            Assert.AreEqual(zapPath + ".cs", csPath);
            Assert.IsTrue(File.Exists(csPath));
        }
    }
}
