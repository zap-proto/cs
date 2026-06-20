using System;

namespace ZapC.CSharp.Generator
{
    /// <summary>
    /// Represents the generation result of a single .zap file
    /// </summary>
    public class FileGenerationResult
    {
        /// <summary>
        /// Constructs an instance in case of successful generation
        /// </summary>
        /// <param name="zapFilePath">path to .zap file</param>
        /// <param name="generatedContent">generated C# code</param>
        public FileGenerationResult(string zapFilePath, string generatedContent)
        {
            ZapFilePath = zapFilePath;
            GeneratedContent = generatedContent;
        }

        /// <summary>
        /// Constructs an instance in case of unsuccessful generation
        /// </summary>
        /// <param name="zapFilePath">path to .zap file</param>
        /// <param name="exception">Exception giving details on the error which prevented generation</param>
        public FileGenerationResult(string zapFilePath, Exception exception)
        {
            ZapFilePath = zapFilePath;
            Exception = exception;
        }

        /// <summary>
        /// Path to .zap file
        /// </summary>
        public string ZapFilePath { get; }

        /// <summary>
        /// Generated C# or null if generation failed
        /// </summary>
        public string GeneratedContent { get; }

        /// <summary>
        /// Exception giving details on the error which prevented generation
        /// </summary>
        public Exception Exception { get; }

        /// <summary>
        /// true iff generation was successful
        /// </summary>
        public bool IsSuccess => !string.IsNullOrEmpty(GeneratedContent);
    }
}
