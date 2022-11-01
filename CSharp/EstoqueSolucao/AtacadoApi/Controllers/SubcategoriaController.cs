using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using System.Runtime.CompilerServices;

namespace AtacadoApi.Controllers
{
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class SubcategoriaController : ControllerBase
    {
        private SubcategoriaServico servico;

        public SubcategoriaController() : base()
        {
            this.servico = new SubcategoriaServico();
        }

        [HttpGet]
        public List<SubcategoriaPoco> GetAll()
        {
            return this.servico.Browse();
        }

        [HttpGet("{chave:int}")]
        public SubcategoriaPoco GetById(int chave)
        {
            return this.servico.Read(chave);
        }

        [HttpPost]
        public SubcategoriaPoco Post([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Add(poco);
        }

        [HttpPut]
        public SubcategoriaPoco Put([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Edit(poco);
        }

        [HttpDelete("{chave:int}")]
        public SubcategoriaPoco DeleteById(int chave)
        {
            return this.servico.Delete(chave);
        }

        [HttpDelete]
        public SubcategoriaPoco Delete([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Delete(poco);
        }
    }
}
