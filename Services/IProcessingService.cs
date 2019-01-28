using System.Collections.Generic;
using System.Threading.Tasks;

namespace simpleinjector_asyncscope.Services
{
    public interface IProcessingService
    {
        Task<string> Process(string input);
    }
}