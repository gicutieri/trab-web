using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Dtos;
using TrabalhoWeb.Ecommerce.Domain.Entidades;

namespace TrabalhoWeb.Ecommerce.Domain.Services
{
    public interface IUsuarioService
    {
        Task<Result> Cadastrar(Usuario usuario);
        Task<Result> Atualizar(Usuario usuario);
    }
}
