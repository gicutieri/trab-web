using System.Threading.Tasks;
using TrabalhoWeb.Ecommerce.Domain.Dtos;
using TrabalhoWeb.Ecommerce.Domain.Entidades;
using TrabalhoWeb.Ecommerce.Domain.Repositorios;

namespace TrabalhoWeb.Ecommerce.Domain.Services
{
    public class AuthService : IAuthService
    {
        private readonly IJwtService _jwtService;
        private readonly IAuthRepositorio _authRepositorio;

        public AuthService(IAuthRepositorio authRepositorio, IJwtService jwtService)
        {
            _authRepositorio = authRepositorio;
            _jwtService = jwtService;
        }

        public async Task<Result<TokenAuth>> Logar(AuthUser user)
        {
            if (user == null || user.UsuarioInvalido())
            {
                return new Result<TokenAuth>(new [] {"Email ou Password inválidos" });
            }

            var userAuth = await _authRepositorio.Logar(user);

            if (userAuth == null)
                return new Result<TokenAuth>(new[] { "Email ou Password inválidos" });

            return new Result<TokenAuth>(new TokenAuth
            {
                access_token = _jwtService.GenerateToken(userAuth)
            });
        }
    }
}
