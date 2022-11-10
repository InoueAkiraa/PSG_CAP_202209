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
    public class CategoriaController : ControllerBase
    {
        private CategoriaServico servico;

        /// <summary>
        /// 
        /// </summary>
        public CategoriaController() : base()
        {
            this.servico = new CategoriaServico();
        }

        /// <summary>
        /// Listar todos os registros da tabela Categoria.
        /// </summary>
        /// <returns>Uma lista com todos os registros.</returns>
        [HttpGet]
        public ActionResult<List<CategoriaPoco>> GetAll()
        {
            try
            {
                List<CategoriaPoco> lista = this.servico.Listar();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista o registro da tabela Categoria de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave">chave primária da tabela</param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<CategoriaPoco> GetById(int chave)
        {
            try
            {
                CategoriaPoco poco = this.servico.PesquisarPorChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a criação de um registro através de uma instância
        /// </summary>
        /// <param name="poco">instância passada como parâmetro</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<CategoriaPoco> Post([FromBody] CategoriaPoco poco) 
        {
            try
            {
                CategoriaPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a alteração de um registro através de uma instância
        /// </summary>
        /// <param name="poco">instância passada como parâmetro</param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<CategoriaPoco> Put([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco novoPoco = this.servico.Alterar(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        /// <summary>
        /// Realiza a exclusão de um registro de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave">chave primária da tabela</param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<CategoriaPoco> DeleteById(int chave)
        {
            try
            {
                CategoriaPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a exclusão de um registro através de uma instância
        /// </summary>
        /// <param name="poco">instância passada como parâmetro</param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult<CategoriaPoco> Delete([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco novoPoco = this.servico.Excluir(poco.Codigo);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
