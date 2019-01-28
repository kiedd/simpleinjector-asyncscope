using System;
using System.Runtime.Serialization;

namespace simpleinjector_asyncscope.Services
{
    [Serializable]
    public class ParameterMutatedException : Exception
    {
        public ParameterMutatedException()
        {
        }

        public ParameterMutatedException(string message) : base(message)
        {
        }

        public ParameterMutatedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParameterMutatedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}