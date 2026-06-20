using System.Collections.Generic;

namespace ZapC.CSharp.MsBuild.Generation
{
    public interface IZapcCsharpGenerator
    {
        IEnumerable<string> GenerateFilesForProject(string projectPath, List<ZapGenJob> jobs, string projectFolder);
    }
}