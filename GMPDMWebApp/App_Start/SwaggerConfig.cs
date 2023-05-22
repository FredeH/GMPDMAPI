using System.Web.Http;
using WebActivatorEx;
using GMPDMWebApp;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace GMPDMWebApp
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c => c.SingleApiVersion("v1", "GMPDMWebApp"))
                .EnableSwaggerUi();
        }
    }
}
