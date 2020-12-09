using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.Web.Http;
using TrabalhoWeb.Ecommerce.Crosscutting.Ioc;

namespace TrabalhoWeb.Ecommerce.Api
{
    public static class SimpleInjectorConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.EnableHttpRequestMessageTracking(config);

            Bootstrapper.RegisterServices(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}