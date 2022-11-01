using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;

namespace AtacadoApi.Controllers
{
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoServico servico;

        public ProdutoController() : base()
        {
            this.servico = new ProdutoServico();
        }

        [HttpGet]
        public List<ProdutoPoco> GetAll()
        {
            return this.servico.Browse();
        }

        [HttpGet("{chave:int}")]
        public ProdutoPoco GetById(int chave)
        {
            return this.servico.Read(chave);
        }

        [HttpPost]
        public ProdutoPoco Post([FromBody] ProdutoPoco poco)
        {
            return this.servico.Add(poco);
        }

        [HttpPut]
        public ProdutoPoco Put([FromBody] ProdutoPoco poco)
        {
            return this.servico.Edit(poco);
        }

        [HttpDelete("{chave:int}")]
        public ProdutoPoco DeleteById(int chave)
        {
            return this.servico.Delete(chave);
        }

        [HttpDelete]
        public ProdutoPoco Delete([FromBody] ProdutoPoco poco)
        {
            return this.servico.Delete(poco);
        }
    }
}
