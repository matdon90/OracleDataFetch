using System.Web.Http;
using WebAPI.App_Start;

namespace WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ContainerConfig.RegisterContainer(GlobalConfiguration.Configuration);
            AutoMapperConfig.AutoMapperRegister();
        }
    }
}
