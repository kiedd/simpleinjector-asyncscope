using System.Collections.Generic;
using System.Threading.Tasks;

namespace simpleinjector_asyncscope.Services
{
    public interface IProcessingServiceFactory
    {
        IProcessingService Create();
        IProcessingContext GetContext();
    }
}