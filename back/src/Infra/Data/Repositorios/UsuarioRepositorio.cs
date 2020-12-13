using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Entidades;
using TrabalhoWeb.Ecommerce.Domain.Repositorios;

namespace TrabalhoWeb.Ecommerce.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private string _hortifrutiConnectionString => ConfigurationManager.ConnectionStrings["hortifruti"].ConnectionString;

        public async Task<int> Atualizar(Usuario usuario)
        {
            using (var connection = new SqlConnection(_hortifrutiConnectionString))
            {
                return await connection.ExecuteAsync(
                    Atualizar_Query,
                    usuario);
            }
        }

        public async Task<int> Cadastrar(Usuario usuario)
        {
            using (var connection = new SqlConnection(_hortifrutiConnectionString))
            {
                return await connection.ExecuteAsync(
                    Cadastrar_Query,
                    usuario);
            }
        }

        private readonly string Atualizar_Query =
$@"
UPDATE [dbo].[Usuario]
   SET [Senha] = @{nameof(Usuario.Senha)}
      ,[Nome] = @{nameof(Usuario.Nome)}
      ,[Cpf] = @{nameof(Usuario.Cpf)}
      ,[Rg] = @{nameof(Usuario.Rg)}
      ,[Telefone] = @{nameof(Usuario.Telefone)}
      ,[DataNascimento] = @{nameof(Usuario.DataNascimento)}
      ,[Email] = @{nameof(Usuario.Email)}
      ,[Endereco] = @{nameof(Usuario.Endereco)}
      ,[Numero] = @{nameof(Usuario.Nome)}
      ,[Complemento] = @{nameof(Usuario.Complemento)}
      ,[Cidade] = @{nameof(Usuario.Cidade)}
      ,[Bairro] = @{nameof(Usuario.Bairro)}
      ,[Estado] = @{nameof(Usuario.Estado)}
      ,[Cep] = @{nameof(Usuario.Cep)}
 WHERE 
    [Id] = @{nameof(Usuario.Id)}
";

        private readonly string Cadastrar_Query =
$@"
INSERT INTO [Usuario]
           ([Senha]
           ,[Nome]
           ,[Cpf]
           ,[Rg]
           ,[Telefone]
           ,[DataNascimento]
           ,[Email]
           ,[Endereco]
           ,[Numero]
           ,[Complemento]
           ,[Cidade]
           ,[Bairro]
           ,[Estado]
           ,[Cep]
           ,[Perfil])
     VALUES
           (@{nameof(Usuario.Senha)}
           ,@{nameof(Usuario.Nome)}
           ,@{nameof(Usuario.Cpf)}
           ,@{nameof(Usuario.Rg)}
           ,@{nameof(Usuario.Telefone)}
           ,@{nameof(Usuario.DataNascimento)}
           ,@{nameof(Usuario.Email)}
           ,@{nameof(Usuario.Endereco)}
           ,@{nameof(Usuario.Numero)}
           ,@{nameof(Usuario.Complemento)}
           ,@{nameof(Usuario.Cidade)}
           ,@{nameof(Usuario.Bairro)}
           ,@{nameof(Usuario.Estado)}
           ,@{nameof(Usuario.Cep)}
           ,@{nameof(Usuario.Perfil)})
";
    }
}
