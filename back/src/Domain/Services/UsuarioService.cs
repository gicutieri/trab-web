using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Dtos;
using TrabalhoWeb.Ecommerce.Domain.Entidades;
using TrabalhoWeb.Ecommerce.Domain.Repositorios;

namespace TrabalhoWeb.Ecommerce.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioService(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<Result> Cadastrar(Usuario usuario)
        {
            if (usuario == null)
            {
                return new Result(false, new [] { "Dados invalidos." });
            }

            if (usuario.UsuarioInvalido())
            {
                return new Result(false, usuario.Erros.ToArray());
            }

            await _usuarioRepositorio.Cadastrar(usuario);

            return new Result(true, string.Empty);
        }

        public async Task<Result> Atualizar(Usuario usuario)
        {
            if (usuario == null)
            {
                return new Result(false, new[] { "Dados invalidos." });
            }

            if (usuario.UsuarioInvalido())
            {
                return new Result(false, usuario.Erros.ToArray());
            }

            await _usuarioRepositorio.Atualizar(usuario);

            return new Result(true, string.Empty);
        }
    }
}
