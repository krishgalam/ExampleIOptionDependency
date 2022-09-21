using ExampleIOptionDependency.Model;
using Microsoft.Extensions.Options;

namespace ExampleIOptionDependency.BusinessLayer
{
    public class DemoApplication : IDemoApplication
    {
        private readonly HariConfig hariConfig;
        public DemoApplication(IOptions<HariConfig> hariConfig)
        {
            this.hariConfig = hariConfig.Value;
        }

        public string GetAppIdFromHariConfig()
        {
            return hariConfig.AppId;
        }

        public string GetClientDescriptionFromHariConfig()
        {
            return hariConfig.ClientDescription;
        }
    }
}
