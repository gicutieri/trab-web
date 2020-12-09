using System.Collections.Generic;
using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Dtos;
using TrabalhoWeb.Ecommerce.Domain.Entidades;

namespace TrabalhoWeb.Ecommerce.Domain.Services
{
    public interface IProdutoService
    {
        Task<Result<IEnumerable<Produto>>> Buscar();
        Task<Result<IEnumerable<Produto>>> Destaques();
    }
}
