using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Entidades;
using TrabalhoWeb.Ecommerce.Domain.Repositorios;

namespace TrabalhoWeb.Ecommerce.Data.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private string _hortifrutiConnectionString => ConfigurationManager.ConnectionStrings["hortifruti"].ConnectionString;

        public async Task<IEnumerable<Produto>> Buscar()
        {
            using (var connection = new SqlConnection(_hortifrutiConnectionString))
            {
                return await connection.QueryAsync<Produto>(
                    Buscar_Query,
                    commandType: System.Data.CommandType.Text);
            }
        }

        public async Task<IEnumerable<Produto>> Destaques()
        {
            using (var connection = new SqlConnection(_hortifrutiConnectionString))
            {
                return await connection.QueryAsync<Produto>(
                    Destaques_Query,
                    commandType: System.Data.CommandType.Text);
            }
        }

        private readonly string Buscar_Query =
$@"
SELECT 
      [Id] AS {nameof(Produto.Id)}, 
      [Nome] AS {nameof(Produto.Nome)}, 
      [Descricao] AS {nameof(Produto.Descricao)}, 
      [Imagem] AS {nameof(Produto.Imagem)}, 
      [Preco] AS {nameof(Produto.Preco)} 
  FROM [Produto] WITH(NOLOCK)
";

        private readonly string Destaques_Query =
$@"
SELECT TOP 4
      [Id] AS {nameof(Produto.Id)}, 
      [Nome] AS {nameof(Produto.Nome)}, 
      [Descricao] AS {nameof(Produto.Descricao)}, 
      [Imagem] AS {nameof(Produto.Imagem)}, 
      [Preco] AS {nameof(Produto.Preco)} 
  FROM [Produto] WITH(NOLOCK)
";
    }
}
