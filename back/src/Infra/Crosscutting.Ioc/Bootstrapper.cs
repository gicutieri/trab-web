using SimpleInjector;
using TrabalhoWeb.Ecommerce.Data.Repositorios;
using TrabalhoWeb.Ecommerce.Domain.Repositorios;
using TrabalhoWeb.Ecommerce.Domain.Services;

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
            container.Register<IAuthService, AuthService>(Lifestyle.Scoped);
            container.Register<IProdutoService, ProdutoService>(Lifestyle.Scoped);
            container.Register<IJwtService, JwtService>(Lifestyle.Scoped);
        }

        private static void RegisterRepositoryData(Container container)
        {
            container.Register<IAuthRepositorio, AuthRepositorio>(Lifestyle.Scoped);
            container.Register<IProdutoRepositorio, ProdutoRepositorio>(Lifestyle.Scoped);
        }
    }
}
