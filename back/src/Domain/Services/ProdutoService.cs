using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Dtos;
using TrabalhoWeb.Ecommerce.Domain.Entidades;
using TrabalhoWeb.Ecommerce.Domain.Repositorios;

namespace TrabalhoWeb.Ecommerce.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoService(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public async Task<Result<IEnumerable<Produto>>> Buscar()
        {
            var produtos = await _produtoRepositorio.Buscar();

            if (!produtos.Any())
                return new Result<IEnumerable<Produto>>(false, "Não há produtos");

            return new Result<IEnumerable<Produto>>(produtos);
        }

        public async Task<Result<IEnumerable<Produto>>> Destaques()
        {
            var destaques = await _produtoRepositorio.Destaques();

            if (!destaques.Any())
                return new Result<IEnumerable<Produto>>(false, "Não há produtos em destaque");

            return new Result<IEnumerable<Produto>>(destaques);
        }
    }
}
