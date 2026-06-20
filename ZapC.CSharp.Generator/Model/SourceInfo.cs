using System;
using System.Collections.Generic;
using System.Text;

namespace ZapC.CSharp.Generator.Model
{
    class SourceInfo
    {
        public string DocComment { get; set; }
        public IReadOnlyList<string> MemberDocComments { get; set; }
    }
}
