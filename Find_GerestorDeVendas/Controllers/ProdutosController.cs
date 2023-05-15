using Find_GerestorDeVendas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Find_GerestorDeVendas.Controllers
{
    [ApiController]
    [Route("produtos")]
    public class ProdutosController : ControllerBase
    {


        public ProdutosController()
        {

        }

        [HttpPost]
        [Route("Criar")]
        public IEnumerable<Produto> Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("Listar")]
        public IEnumerable<Produto> Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("Alterar")]
        public IEnumerable<Produto> Get()
        {
            return Ok();
        }
        [HttpPost]
        [Route("Remover")]
        public IEnumerable<Produto> Get()
        {
            return Ok();
        }

    }
}