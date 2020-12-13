using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using TrabalhoWeb.Ecommerce.Domain.Dtos;
using TrabalhoWeb.Ecommerce.Domain.Entidades;
using TrabalhoWeb.Ecommerce.Domain.Services;

namespace TrabalhoWeb.Ecommerce.Api.Controllers
{
    [RoutePrefix("api/Auth")]
    public class AuthController : ApiController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [AllowAnonymous]
        [EnableCors("*", "*", "*")]
        [SwaggerResponse(HttpStatusCode.OK, "Login aceito.", typeof(TokenAuth))]
        [SwaggerResponse((HttpStatusCode)422, "Dados invalidos.")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro não esperado.")]
        public async Task<HttpResponseMessage> Post([FromBody] AuthUser user)
        {
            try
            {
                var result = await _authService.Logar(user);

                if (result.Sucesso)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, result.Data);
                }

                return Request.CreateResponse((HttpStatusCode)422, result.Erros);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
