using System.Collections.Generic;
using System.Threading.Tasks;

namespace simpleinjector_asyncscope.Services
{
    public class ProcessingService : IProcessingService
    {
        private readonly IProcessingContext context;
        private readonly ILesserProcessor lesserProcessor;

        public ProcessingService(IProcessingContext context, ILesserProcessor lesserProcessor)
        {
            this.context = context;
            this.lesserProcessor = lesserProcessor;
        }

        public async Task<string> Process(string input)
        {
            await Task.Delay(100);
            return await lesserProcessor.Process(input);
        }
    }
}