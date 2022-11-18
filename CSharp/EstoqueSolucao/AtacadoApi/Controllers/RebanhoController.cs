using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Pecuaria;
using System.Collections.Generic;
using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using Atacado.Servico.Pecuaria;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/pecuaria/[controller]")]
    [ApiController]
    public class RebanhoController : ControllerBase
    {
        private RebanhoServico servico;

        /// <summary>
        /// 
        /// </summary>
        public RebanhoController() : base()
        {
            this.servico = new RebanhoServico();
        }

        /// <summary>
        /// Listar todos os registros da tabela Rebanho.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<RebanhoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<RebanhoPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Rebanho de acordo com o código de Categoria informado.
        /// </summary>
        /// <param name="munid"></param>
        /// <returns></returns>
        [HttpGet("PorMunicipio/{munid:int}")]
        public ActionResult<List<RebanhoPoco>> GetPorMunicipio(int munid)
        {
            try
            {
                List<RebanhoPoco> listaPoco = this.servico.Consultar(mun => mun.CodigoMunicipio == munid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Rebanho de acordo com o código de Subcategoria informado.
        /// </summary>
        /// <param name="tipid"></param>
        /// <returns></returns>
        [HttpGet("PorTipoRebanho/{tipid:int}/PorMunicipio/{munid:int}")]
        public ActionResult<List<RebanhoPoco>> GetPorTipoRebanhoPorMunicipio(int tipid, int munid)
        {
            try
            {
                List<RebanhoPoco> listaPoco = this.servico.Consultar(tip => (tip.CodigoTipoRebanho == tipid) && (tip.CodigoMunicipio == munid)).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista o registro da tabela Rebanho de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<RebanhoPoco> GetById(int chave)
        {
            try
            {
                RebanhoPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<RebanhoPoco> Post([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<RebanhoPoco> Put([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<RebanhoPoco> DeleteById(int chave)
        {
            try
            {
                RebanhoPoco poco = this.servico.Excluir(chave);
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
        public ActionResult<RebanhoPoco> Delete([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco novoPoco = this.servico.Excluir(poco.CodigoRebanho);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
