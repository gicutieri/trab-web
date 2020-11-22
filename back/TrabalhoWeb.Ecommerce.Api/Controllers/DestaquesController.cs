using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace TrabalhoWeb.Ecommerce.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestaquesController : ControllerBase
    {
        private readonly ILogger<DestaquesController> _logger;

        public DestaquesController(ILogger<DestaquesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            _logger.LogDebug("DestaquesController - Get");

            int count = 0;
            return new[] {
                new Produto { Id = ++count, Nome = "Abacate " + count, Descricao = "Desc " + count, Imagem = "/imagens/abacate.jpg", Preco = count },
                new Produto { Id = ++count, Nome = "Abacate " + count, Descricao = "Desc " + count, Imagem = "/imagens/abacate.jpg", Preco = count },
                new Produto { Id = ++count, Nome = "Abacate " + count, Descricao = "Desc " + count, Imagem = "/imagens/abacate.jpg", Preco = count },
                new Produto { Id = ++count, Nome = "Abacate " + count, Descricao = "Desc " + count, Imagem = "/imagens/abacate.jpg", Preco = count },
            };
        }
    }
}
