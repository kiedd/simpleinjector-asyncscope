using System.Threading.Tasks;

namespace simpleinjector_asyncscope.Services
{
    public interface ILesserProcessor
    {
        Task<string> Process(string input);
    }
}