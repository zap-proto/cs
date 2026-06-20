using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Resources;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace ZapC.CSharp.MsBuild.Generation
{
    public class GenerateZapFileCodeBehindTask : Task
    {
        public GenerateZapFileCodeBehindTask()
        {
            CodeBehindGenerator = new ZapFileCodeBehindGenerator(Log);
        }

        public IZapcCsharpGenerator CodeBehindGenerator { get; set; }

        [Required]
        public string ProjectPath { get; set; }

        public string ProjectFolder => Path.GetDirectoryName(ProjectPath);

        public ITaskItem[] ZapFiles { get; set; }

        [Output]
        public ITaskItem[] GeneratedFiles { get; private set; }

        static ZapGenJob ToGenJob(ITaskItem item)
        {
            var job = new ZapGenJob()
            {
                ZapPath = item.GetMetadata("FullPath"),
                WorkingDirectory = item.GetMetadata("WorkingDirectory")
            };

            string importPaths = item.GetMetadata("ImportPaths");

            if (!string.IsNullOrWhiteSpace(importPaths))
            {
                job.AdditionalArguments.AddRange(importPaths.Split(new char[] { ';' }, 
                    StringSplitOptions.RemoveEmptyEntries).Select(p => $"-I\"{p.TrimEnd('\\')}\""));
            }

            string sourcePrefix = item.GetMetadata("SourcePrefix");

            if (!string.IsNullOrWhiteSpace(sourcePrefix))
            {
                job.AdditionalArguments.Add(sourcePrefix);
            }


            string verbose = item.GetMetadata("Verbose");

            if ("true".Equals(verbose, StringComparison.OrdinalIgnoreCase))
            {
                job.AdditionalArguments.Add("--verbose");
            }

            return job;
        }

        public override bool Execute()
        {
            try
            {
                try
                {
                    var currentProcess = Process.GetCurrentProcess();

                    Log.LogWithNameTag(Log.LogMessage, $"process: {currentProcess.ProcessName}, pid: {currentProcess.Id}, CD: {Environment.CurrentDirectory}");

                    foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                    {
                        Log.LogWithNameTag(Log.LogMessage, "  " + assembly.FullName);
                    }
                }
                catch (Exception e)
                {
                    Log.LogWithNameTag(Log.LogMessage, $"Error when dumping process info: {e}");
                }

                AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

                var generator = CodeBehindGenerator ?? new ZapFileCodeBehindGenerator(Log);

                Log.LogWithNameTag(Log.LogMessage, "Starting GenerateZapFileCodeBehind");

                var zapFiles = ZapFiles?.Select(ToGenJob).ToList() ?? new List<ZapGenJob>();

                var generatedFiles = generator.GenerateFilesForProject(
                    ProjectPath,
                    zapFiles,
                    ProjectFolder);

                GeneratedFiles = generatedFiles.Select(file => new TaskItem { ItemSpec = file }).ToArray();

                return !Log.HasLoggedErrors;
            }
            catch (Exception e)
            {
                if (e.InnerException != null)
                {
                    if (e.InnerException is FileLoadException fle)
                    {
                        Log?.LogWithNameTag(Log.LogError, $"FileLoadException Filename: {fle.FileName}");
                        Log?.LogWithNameTag(Log.LogError, $"FileLoadException FusionLog: {fle.FusionLog}");
                        Log?.LogWithNameTag(Log.LogError, $"FileLoadException Message: {fle.Message}");
                    }

                    Log?.LogWithNameTag(Log.LogError, e.InnerException.ToString());
                }

                Log?.LogWithNameTag(Log.LogError, e.ToString());
                return false;
            }
            finally
            {
                AppDomain.CurrentDomain.AssemblyResolve -= CurrentDomain_AssemblyResolve;
            }
        }

        private System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Log.LogWithNameTag(Log.LogMessage, args.Name);
            

            return null;
        }

    }


}