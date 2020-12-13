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
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [EnableCors("*", "*", "*")]
        [SwaggerResponse(HttpStatusCode.OK, "Usuario cadastrado.", typeof(TokenAuth))]
        [SwaggerResponse(HttpStatusCode.PreconditionFailed, "Dados invalidos.")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro não esperado.")]
        public async Task<HttpResponseMessage> Post([FromBody] Usuario usuario)
        {
            try
            {
                var result = await _usuarioService.Cadastrar(usuario);

                if (result.Sucesso)
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

                return Request.CreateResponse(HttpStatusCode.PreconditionFailed, result.Erros);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [HttpPut]
        [EnableCors("*", "*", "*")]
        [SwaggerResponse(HttpStatusCode.OK, "Usuario cadastrado.", typeof(TokenAuth))]
        [SwaggerResponse(HttpStatusCode.PreconditionFailed, "Dados invalidos.")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro não esperado.")]
        public async Task<HttpResponseMessage> Put([FromBody] Usuario usuario)
        {
            try
            {
                var result = await _usuarioService.Atualizar(usuario);

                if (result.Sucesso)
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

                return Request.CreateResponse(HttpStatusCode.PreconditionFailed, result.Erros);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
