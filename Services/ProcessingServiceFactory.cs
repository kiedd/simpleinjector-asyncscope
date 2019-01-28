using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleInjector;

namespace simpleinjector_asyncscope.Services
{
    public class ProcessingServiceFactory : IProcessingServiceFactory
    {
        private readonly Container container;
        public ProcessingServiceFactory(Container container)
        {
            this.container = container;
        }

        public IProcessingService Create()
        {
            return container.GetInstance<IProcessingService>();
        }

        public IProcessingContext GetContext()
        {
            return container.GetInstance<IProcessingContext>();
        }
    }
}