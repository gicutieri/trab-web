using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Dtos;
using TrabalhoWeb.Ecommerce.Domain.Entidades;

namespace TrabalhoWeb.Ecommerce.Domain.Services
{
    public interface IAuthService
    {
        Task<Result<TokenAuth>> Logar(AuthUser user);
    }
}
