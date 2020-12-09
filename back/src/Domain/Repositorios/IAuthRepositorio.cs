using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Entidades;

namespace TrabalhoWeb.Ecommerce.Domain.Repositorios
{
    public interface IAuthRepositorio
    {
        Task<AuthUser> Logar(AuthUser user);
    }
}
