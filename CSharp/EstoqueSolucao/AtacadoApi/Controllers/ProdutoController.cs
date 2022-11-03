using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoServico servico;

        /// <summary>
        /// 
        /// </summary>
        public ProdutoController() : base()
        {
            this.servico = new ProdutoServico();
        }

        /// <summary>
        /// Listar todos os registros da tabela Produto.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ProdutoPoco> GetAll()
        {
            return this.servico.Browse();
        }

        /// <summary>
        /// Listar todos os registros da tabela Produto de acordo com o código de Categoria informado.
        /// </summary>
        /// <param name="catid"></param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public List<ProdutoPoco> GetPorCategoria(int catid)
        {
            return this.servico.Browse(cat => cat.CodigoCategoria == catid).ToList();
        }

        /// <summary>
        /// Listar todos os registros da tabela Produto de acordo com o código de Subcategoria informado.
        /// </summary>
        /// <param name="subid"></param>
        /// <returns></returns>
        [HttpGet("PorSubcategoria/{subid:int}")]
        public List<ProdutoPoco> GetPorSubcategoria(int subid)
        {
            return this.servico.Browse(sub => sub.CodigoSubcategoria == subid).ToList();
        }

        /// <summary>
        /// Lista todos os registros de acordo com os códigos de Categoria e Subcategoria informados.
        /// </summary>
        /// <param name="catid"></param>
        /// <param name="subid"></param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}/PorSubcategoria/{subid:int}")]
        public List<ProdutoPoco> GetPorCategoriaPorSubcategoria(int catid, int subid)
        {
            return this.servico.Browse(pro => (pro.CodigoCategoria == catid) && (pro.CodigoSubcategoria == subid))
                .ToList();
        }

        /// <summary>
        /// Lista o registro da tabela Produto de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ProdutoPoco GetById(int chave)
        {
            return this.servico.Read(chave);
        }

        /// <summary>
        /// Realiza a criação de um registro através de uma instância
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ProdutoPoco Post([FromBody] ProdutoPoco poco)
        {
            return this.servico.Add(poco);
        }

        /// <summary>
        /// Realiza a alteração de um registro através de uma instância
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ProdutoPoco Put([FromBody] ProdutoPoco poco)
        {
            return this.servico.Edit(poco);
        }

        /// <summary>
        /// Realiza a exclusão de um registro de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ProdutoPoco DeleteById(int chave)
        {
            return this.servico.Delete(chave);
        }

        /// <summary>
        /// Realiza a exclusão de um registro através de uma instância
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public ProdutoPoco Delete([FromBody] ProdutoPoco poco)
        {
            return this.servico.Delete(poco);
        }
    }
}
