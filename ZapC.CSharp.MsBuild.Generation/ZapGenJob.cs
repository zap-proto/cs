using System.Collections.Generic;

namespace ZapC.CSharp.MsBuild.Generation
{
    public class ZapGenJob
    {
        public string ZapPath { get; set; }
        public string WorkingDirectory { get; set; }
        public List<string> AdditionalArguments { get; } = new List<string>();
    }
}