using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using TrabalhoWeb.Ecommerce.Domain.Entidades;
using TrabalhoWeb.Ecommerce.Domain.Services;

namespace TrabalhoWeb.Ecommerce.Api.Controllers
{
    [RoutePrefix("api/Produtos")]
    public class ProdutoController : ApiController
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        [SwaggerResponse(HttpStatusCode.OK, "Buscar produtos.", typeof(IEnumerable<Produto>))]
        [SwaggerResponse(HttpStatusCode.NotFound, "Não há produtos cadastrados.")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro não esperado.")]
        public async Task<HttpResponseMessage> Get()
        {
            try
            {
                var result = await _produtoService.Buscar();

                if (result.Sucesso)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, result.Data);
                }

                return Request.CreateResponse(HttpStatusCode.NotFound, result.Mensagem);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
