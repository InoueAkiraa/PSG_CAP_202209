using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;

namespace AtacadoApi.Controllers
{
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private CategoriaServico servico;
        public CategoriaController() : base()
        {
            this.servico = new CategoriaServico();
        }

        [HttpGet]
        public List<CategoriaPoco> GetAll()
        {
            return this.servico.Browse();
        }

        [HttpGet("{chave:int}")]
        public CategoriaPoco GetById(int chave)
        {
            return this.servico.Read(chave);
        }

        [HttpPost]
        public CategoriaPoco Post([FromBody] CategoriaPoco poco) 
        {
            return this.servico.Add(poco);
        }

        [HttpPut]
        public CategoriaPoco Put([FromBody] CategoriaPoco poco)
        {
            return this.servico.Edit(poco);
        }

        [HttpDelete("{chave:int}")]
        public CategoriaPoco DeleteById(int chave)
        {
            return this.servico.Delete(chave);
        }

        [HttpDelete]
        public CategoriaPoco Delete([FromBody] CategoriaPoco poco)
        {
            return this.servico.Delete(poco);
        }
    }
}
