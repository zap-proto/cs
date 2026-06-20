using System;

namespace ZapC.CSharp.Generator.CodeGen
{
    abstract class SkeletonWorder : Zap.Rpc.Skeleton<object>
    {
        public const string SetMethodTableName = nameof(SkeletonWorder.SetMethodTable);
        public const string ImplName = nameof(SkeletonWorder.Impl);
    }
}
