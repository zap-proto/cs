using System;

namespace Zap
{
    static class ListSerializerHelper
    {
        public static void EnsureAllocated(SerializerState serializer)
        {
            if (!serializer.IsAllocated)
                throw new InvalidOperationException("Call Init() first");
        }
    }
}