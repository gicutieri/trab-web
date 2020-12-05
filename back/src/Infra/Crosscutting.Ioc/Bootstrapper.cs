using SimpleInjector;

namespace TrabalhoWeb.Ecommerce.Crosscutting.Ioc
{
    public static class Bootstrapper
    {
        public static void RegisterServices(Container container)
        {
            RegisterDomains(container);
            RegisterRepositoryData(container);
        }

        private static void RegisterDomains(Container container)
        {

        }

        private static void RegisterRepositoryData(Container container)
        {

        }
    }
}
