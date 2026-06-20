using System;

namespace ZapC.CSharp.Generator.Model
{
    class InvalidSchemaException : Exception
    {
        public InvalidSchemaException(string message) : base(message)
        {
        }
    }
}
