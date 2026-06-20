using ZapC.CSharp.Generator;
using System;
using System.Collections.Generic;
using System.IO;

namespace ZapC.CSharp.MsBuild.Generation
{
    public class ZapCodeBehindGenerator : IDisposable
    {

        public void InitializeProject(string projectPath)
        {
        }


        public CsFileGeneratorResult GenerateCodeBehindFile(ZapGenJob job)
        {
            string zapFile = job.ZapPath;

            // Works around a weird zap.exe behavior: When the input file is empty, it will spit out an exception dump
            // instead of a parse error. But the parse error is nice because it contains a generated ID. We want the parse error!
            // Workaround: Generate a temporary file that contains a single line break (such that it is not empty...)
            try
            {
                if (File.Exists(zapFile) && new FileInfo(zapFile).Length == 0)
                {
                    string tempFile = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + ".zap");

                    File.WriteAllText(tempFile, Environment.NewLine);
                    try
                    {
                        var jobCopy = new ZapGenJob()
                        {
                            ZapPath = tempFile,
                            WorkingDirectory = job.WorkingDirectory
                        };

                        jobCopy.AdditionalArguments.AddRange(job.AdditionalArguments);

                        return GenerateCodeBehindFile(jobCopy);
                    }
                    finally
                    {
                        File.Delete(tempFile);
                    }
                }
            }
            catch
            {
            }

            var args = new List<string>();
            args.AddRange(job.AdditionalArguments);
            args.Add(zapFile);

            var result = ZapCompilation.InvokeZapAndGenerate(args, job.WorkingDirectory);

            if (result.IsSuccess)
            {
                if (result.GeneratedFiles.Count == 1)
                {
                    return new CsFileGeneratorResult(
                        result.GeneratedFiles[0],
                        zapFile + ".cs",
                        result.Messages);
                }
                else
                {
                    return new CsFileGeneratorResult(
                        "Code generation produced more than one file. This is not supported.",
                        result.Messages);
                }
            }
            else
            {
                switch (result.ErrorCategory)
                {
                    case ZapProcessFailure.NotFound:
                        return new CsFileGeneratorResult("Unable to find zap.exe - please install zap on your system first.");

                    case ZapProcessFailure.BadInput:
                        return new CsFileGeneratorResult("Invalid schema", result.Messages);

                    case ZapProcessFailure.BadOutput:
                        return new CsFileGeneratorResult(
                            "Internal error: zap.exe produced a binary code generation request which was not understood by the backend",
                            result.Messages);

                    default:
                        throw new NotSupportedException("Invalid error category");
                }
            }
        }

        public void Dispose()
        {
        }
    }
}