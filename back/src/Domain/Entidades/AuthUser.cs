
namespace TrabalhoWeb.Ecommerce.Domain.Entidades
{
    public class AuthUser
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Perfil { get; set; }

        public bool UsuarioInvalido()
        {
            return string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password);
        }
    }
}
