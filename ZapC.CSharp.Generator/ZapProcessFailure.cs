namespace ZapC.CSharp.Generator
{
    /// <summary>
    /// Why did invocation of zapc.exe fail?
    /// </summary>
    public enum ZapProcessFailure
    {
        /// <summary>
        /// Because zapc.exe was not found. It is probably not installed.
        /// </summary>
        NotFound,

        /// <summary>
        /// Because it exited with an error. Probably invalid .zap file input.
        /// </summary>
        BadInput,

        /// <summary>
        /// Because it produced an apparently bad code generation request.
        /// </summary>
        BadOutput
    }
}
