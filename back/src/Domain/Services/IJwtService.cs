using TrabalhoWeb.Ecommerce.Domain.Entidades;

namespace TrabalhoWeb.Ecommerce.Domain.Services
{
    public interface IJwtService
    {
        string GenerateToken(AuthUser authUser, int expireMinutes = 20);
    }
}
