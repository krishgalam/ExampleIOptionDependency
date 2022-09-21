using ExampleIOptionDependency.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExampleIOptionDependencyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OptionDemoController : ControllerBase
    {
        private readonly ILogger<OptionDemoController> logger;
        private readonly IDemoApplication demoApplication;

        public OptionDemoController(ILogger<OptionDemoController> logger, IDemoApplication demoApplication)
        {
            this.demoApplication = demoApplication;
            this.logger = logger;
        }

        [HttpGet]
        [Route("GetAppId")]
        public string GetAppId()
        {
            return "Value from appsetting json file, AppID  : " + demoApplication.GetAppIdFromHariConfig();
        }

        [HttpGet]
        [Route("GetClientDescription")]
        public string GetClientDescriptionFromHariConfig()
        {
            return "Value from appsetting json file, ClientDescription  : " + demoApplication.GetClientDescriptionFromHariConfig();
        }
    }
}