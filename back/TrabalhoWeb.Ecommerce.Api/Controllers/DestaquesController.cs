using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return new[] {
                new Produto { Id = 1, Nome = "Abacate 1", Descricao = "Desc 1", Imagem = "/assets/Home/abacate.jpg", Preco = 1.11m },
                new Produto { Id = 2, Nome = "Abacate 2", Descricao = "Desc 2", Imagem = "/assets/Home/abacate.jpg", Preco = 2.22m },
                new Produto { Id = 3, Nome = "Abacate 3", Descricao = "Desc 3", Imagem = "/assets/Home/abacate.jpg", Preco = 3.33m },
                new Produto { Id = 4, Nome = "Abacate 4", Descricao = "Desc 4", Imagem = "/assets/Home/abacate.jpg", Preco = 4.44m },
                new Produto { Id = 5, Nome = "Abacate 5", Descricao = "Desc 5", Imagem = "/assets/Home/abacate.jpg", Preco = 5.55m },
                new Produto { Id = 6, Nome = "Abacate 6", Descricao = "Desc 6", Imagem = "/assets/Home/abacate.jpg", Preco = 6.66m },
                new Produto { Id = 7, Nome = "Abacate 7", Descricao = "Desc 7", Imagem = "/assets/Home/abacate.jpg", Preco = 7.77m },
                new Produto { Id = 8, Nome = "Abacate 8", Descricao = "Desc 8", Imagem = "/assets/Home/abacate.jpg", Preco = 8.88m },
            };
        }
    }
}
