using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Entidades;
using TrabalhoWeb.Ecommerce.Domain.Repositorios;

namespace TrabalhoWeb.Ecommerce.Data.Repositorios
{
    public class AuthRepositorio : IAuthRepositorio
    {
        private string _hortifrutiConnectionString => ConfigurationManager.ConnectionStrings["hortifruti"].ConnectionString;

        public async Task<AuthUser> Logar(AuthUser user)
        {
            using (var connection = new SqlConnection(_hortifrutiConnectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<AuthUser>(
                    Logar_Query,
                    commandType: System.Data.CommandType.Text,
                    param: new
                    {
                        EMAIL = user.Email,
                        PASSWORD = user.Password
                    });
            }
        }

        private readonly string Logar_Query =
$@"
SELECT 
    [Id] AS {nameof(AuthUser.Id)}, 
    [Nome] AS {nameof(AuthUser.Nome)}, 
    [Email] AS {nameof(AuthUser.Email)}, 
    [Perfil] AS {nameof(AuthUser.Perfil)} 
FROM [Usuario] WITH(NOLOCK) 
WHERE 
    Email = @EMAIL 
AND Senha = @PASSWORD 
";
    }
}
