using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Entidades;

namespace TrabalhoWeb.Ecommerce.Domain.Repositorios
{
    public interface IUsuarioRepositorio
    {
        Task<int> Cadastrar(Usuario usuario);
        Task<int> Atualizar(Usuario usuario);
    }
}
