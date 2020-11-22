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
            _logger.LogDebug("Get");

            return new[] {
                new Produto { Id = 1, Nome = "Abacate 1", Descricao = "Desc 1", Imagem = "/imagens/abacate.jpg", Preco = 1.11m },
                new Produto { Id = 2, Nome = "Abacate 2", Descricao = "Desc 2", Imagem = "/imagens/abacate.jpg", Preco = 2.22m },
                new Produto { Id = 3, Nome = "Abacate 3", Descricao = "Desc 3", Imagem = "/imagens/abacate.jpg", Preco = 3.33m },
                new Produto { Id = 4, Nome = "Abacate 4", Descricao = "Desc 4", Imagem = "/imagens/abacate.jpg", Preco = 4.44m },
            };
        }
    }
}
