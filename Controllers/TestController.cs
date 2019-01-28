using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using simpleinjector_asyncscope.Services;

namespace simpleinjector_asyncscope.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        private readonly IProcessingServiceFactory processingServiceFactory;
        private readonly Container container;
        public TestController(Container container, IProcessingServiceFactory processingServiceFactory)
        {
            this.processingServiceFactory = processingServiceFactory;
            this.container = container;
        }

        [HttpGet]
        public async Task<ActionResult<List<string>>> Get(string input, string ctx1, string ctx2)
        {
            var resultTasks = new List<Task<string>>();

            using (AsyncScopedLifestyle.BeginScope(container))
            {
                var processingService = processingServiceFactory.Create();
                var processingContext = processingServiceFactory.GetContext();
                processingContext.ContextParameter1 = "some hardcoded 1 v1";
                processingContext.ContextParameter2 = "some hardcoded 2 v1";
                resultTasks.Add(processingService.Process(input));
            }

            using (AsyncScopedLifestyle.BeginScope(container))
            {
                var processingService = processingServiceFactory.Create();
                var processingContext = processingServiceFactory.GetContext();
                processingContext.ContextParameter1 = ctx1;
                processingContext.ContextParameter2 = ctx2;
                resultTasks.Add(processingService.Process(input));
            }

            using (AsyncScopedLifestyle.BeginScope(container))
            {
                var processingService = processingServiceFactory.Create();
                var processingContext = processingServiceFactory.GetContext();
                processingContext.ContextParameter1 = "some hardcoded 1 v2";
                processingContext.ContextParameter2 = "some hardcoded 2 v2";
                resultTasks.Add(processingService.Process(input));
            }

            var result = await Task.WhenAll(resultTasks);

            return Ok(result);
        }
    }
}