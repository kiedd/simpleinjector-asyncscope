using System;

namespace simpleinjector_asyncscope.Services
{
    public class ProcessingContext : IProcessingContext
    {
        private string contextParameter1 = null;
        private string contextParameter2 = null;

        public ProcessingContext()
        {
            Console.WriteLine("[ProcessingContext] Contructor call");
        }

        public string ContextParameter1
        {
            get
            {
                if (contextParameter1 == null)
                {
                    throw new ParameterUndefinedException("ContextParameter1 is undefined");
                }

                return contextParameter1;
            }
            set
            {
                if (contextParameter1 != null)
                {
                    throw new ParameterMutatedException($"ContextParameter1 was mutated, original value {contextParameter1}, new value {value}");
                }

                contextParameter1 = value;
            }
        }

        public string ContextParameter2
        {
            get
            {
                if (contextParameter2 == null)
                {
                    throw new ParameterUndefinedException("ContextParameter2 is undefined");
                }

                return contextParameter2;
            }
            set
            {
                if (contextParameter2 != null)
                {
                    throw new ParameterMutatedException($"ContextParameter2 was mutated, original value {contextParameter2}, new value {value}");
                }

                contextParameter2 = value;
            }
        }
    }
}
