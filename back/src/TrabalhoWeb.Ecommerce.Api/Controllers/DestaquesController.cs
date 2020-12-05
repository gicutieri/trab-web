using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using TrabalhoWeb.Ecommerce.Domain.Entidades;

namespace TrabalhoWeb.Ecommerce.Api.Controllers
{
    [RoutePrefix("api/destaques")]
    public class DestaquesController : ApiController
    {
        [HttpGet]
        [EnableCors("*", "*", "*")]
        [SwaggerResponse(HttpStatusCode.OK, "Buscar produtos.", typeof(IEnumerable<Produto>))]
        [SwaggerResponse(HttpStatusCode.NotFound, "Não há produtos cadastrados.")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro não esperado.")]
        public IHttpActionResult Get()
        {
            int count = 0;
            return Ok(new Produto[] {
                new Produto { Id = ++count, Nome = "Abacate " + count, Descricao = "Desc " + count, Imagem = "/imagens/abacate.jpg", Preco = count },
                new Produto { Id = ++count, Nome = "Abacate " + count, Descricao = "Desc " + count, Imagem = "/imagens/abacate.jpg", Preco = count },
                new Produto { Id = ++count, Nome = "Abacate " + count, Descricao = "Desc " + count, Imagem = "/imagens/abacate.jpg", Preco = count },
                new Produto { Id = ++count, Nome = "Abacate " + count, Descricao = "Desc " + count, Imagem = "/imagens/abacate.jpg", Preco = count },
            });
        }
    }
}
