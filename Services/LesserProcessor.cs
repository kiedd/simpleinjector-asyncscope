using System.Threading.Tasks;

namespace simpleinjector_asyncscope.Services
{
    public class LesserProcessor : ILesserProcessor
    {
        private readonly IProcessingContext context;
        public LesserProcessor(IProcessingContext context)
        {
            this.context = context;
        }
        public async Task<string> Process(string input)
        {
            await Task.Delay(100);
            return $"ctx1: {context.ContextParameter1}; ctx2: {context.ContextParameter2}; {input}";
        }
    }
}