using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using System.Runtime.CompilerServices;

namespace AtacadoApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class SubcategoriaController : ControllerBase
    {
        private SubcategoriaServico servico;

        /// <summary>
        /// 
        /// </summary>
        public SubcategoriaController() : base()
        {
            this.servico = new SubcategoriaServico();
        }

        /// <summary>
        /// Listar todos os registros da tabela Subcategoria.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<SubcategoriaPoco> GetAll()
        {
            return this.servico.Browse();
        }

        /// <summary>
        /// Listar todos os registros da tabela Subcategoria de acordo com o código de Categoria informado.
        /// </summary>
        /// <param name="catid">Código da categoria (chave estrangeira) da tabela Subcategoria</param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public List<SubcategoriaPoco> GetPorCategoria(int catid)
        {
            return this.servico.Browse(sub => sub.CodigoCategoria == catid).ToList();
        }

        /// <summary>
        /// Lista o registro da tabela Subcategoria de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave">chave primária da tabela</param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public SubcategoriaPoco GetById(int chave)
        {
            return this.servico.Read(chave);
        }

        /// <summary>
        /// Realiza a criação de um registro através de uma instância
        /// </summary>
        /// <param name="poco">instância passada como parâmetro</param>
        /// <returns></returns>
        [HttpPost]
        public SubcategoriaPoco Post([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Add(poco);
        }

        /// <summary>
        /// Realiza a alteração de um registro através de uma instância
        /// </summary>
        /// <param name="poco">instância passada como parâmetro</param>
        /// <returns></returns>
        [HttpPut]
        public SubcategoriaPoco Put([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Edit(poco);
        }

        /// <summary>
        /// Realiza a exclusão de um registro de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public SubcategoriaPoco DeleteById(int chave)
        {
            return this.servico.Delete(chave);
        }

        /// <summary>
        /// Realiza a exclusão de um registro através de uma instância
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public SubcategoriaPoco Delete([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Delete(poco);
        }
    }
}
