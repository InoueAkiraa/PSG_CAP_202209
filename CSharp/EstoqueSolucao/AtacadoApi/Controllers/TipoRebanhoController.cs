using Atacado.Servico.Pecuaria;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Pecuaria;
using System.Collections.Generic;
using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using Atacado.DB.EF.Database;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/pecuaria/[controller]")]
    [ApiController]
    public class TipoRebanhoController : ControllerBase
    {
        private TipoRebanhoServico servico;

        /// <summary>
        /// 
        /// </summary>
        public TipoRebanhoController(ProjetoAcademiaContext context) : base()
        {
            this.servico = new TipoRebanhoServico(context);
        }

        /// <summary>
        /// Listar todos os registros da tabela TipoRebanho.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<TipoRebanhoPoco>> GetAll()
        {
            try
            {
                List<TipoRebanhoPoco> listaPoco = this.servico.Listar();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista o registro da tabela TipoRebanho de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<TipoRebanhoPoco> GetById(int chave)
        {
            try
            {
                TipoRebanhoPoco poco = this.servico.PesquisarPorChave(chave);
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
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<TipoRebanhoPoco> Post([FromBody] TipoRebanhoPoco poco)
        {
            try
            {
                TipoRebanhoPoco novoPoco = this.servico.Inserir(poco);
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
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<TipoRebanhoPoco> Put([FromBody] TipoRebanhoPoco poco)
        {
            try
            {
                TipoRebanhoPoco novoPoco = this.servico.Alterar(poco);
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
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<TipoRebanhoPoco> DeleteById(int chave)
        {
            try
            {
                TipoRebanhoPoco poco = this.servico.Excluir(chave);
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
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult<TipoRebanhoPoco> Delete([FromBody] TipoRebanhoPoco poco)
        {
            try
            {
                TipoRebanhoPoco novoPoco = this.servico.Excluir(poco.CodigoTipoRebanho);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
