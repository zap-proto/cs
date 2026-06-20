using System.Collections.Generic;

namespace ZapC.CSharp.Generator.Model
{
    interface IHasGenericParameters
    {
        List<string> GenericParameters { get; }
    }
}
