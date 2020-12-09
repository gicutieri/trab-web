using System.Collections.Generic;
using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Entidades;

namespace TrabalhoWeb.Ecommerce.Domain.Repositorios
{
    public interface IProdutoRepositorio
    {
        Task<IEnumerable<Produto>> Buscar();
        Task<IEnumerable<Produto>> Destaques();
    }
}
