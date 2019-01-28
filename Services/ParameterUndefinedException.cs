using System;
using System.Runtime.Serialization;

namespace simpleinjector_asyncscope.Services
{
    [Serializable]
    public class ParameterUndefinedException : Exception
    {
        public ParameterUndefinedException()
        {
        }

        public ParameterUndefinedException(string message) : base(message)
        {
        }

        public ParameterUndefinedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParameterUndefinedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}