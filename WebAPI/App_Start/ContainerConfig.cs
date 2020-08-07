using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using DAL.Interfaces;
using DAL.Services;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace WebAPI.App_Start
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<BearingChokesDataService>().As<IBearingChokesData>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}