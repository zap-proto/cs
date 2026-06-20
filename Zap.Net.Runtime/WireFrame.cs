using System;
using System.Collections.Generic;

namespace Zap
{
    /// <summary>
    /// Represents a ZAP message. Actually a lightweight wrapper struct around a read-only list of memory segments.
    /// </summary>
    public struct WireFrame
    {
        /// <summary>
        /// The message segments
        /// </summary>
        public readonly IReadOnlyList<Memory<ulong>> Segments;

        /// <summary>
        /// Constructs a message from a list of segments.
        /// </summary>
        public WireFrame(IReadOnlyList<Memory<ulong>> segments)
        {
            Segments = segments;
        }
    }
}