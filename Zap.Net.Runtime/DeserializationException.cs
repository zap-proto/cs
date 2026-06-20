using System;

namespace Zap
{
    /// <summary>
    /// This exception gets thrown when a ZAP object could not be deserialized correctly.
    /// </summary>
    public class DeserializationException : Exception
    {
        /// <summary>
        /// Constructs an instance
        /// </summary>
        public DeserializationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructs an instance with message and inner exception
        /// </summary>
        public DeserializationException(string message, Exception innerException): 
            base(message, innerException)
        {
        }
    }
}