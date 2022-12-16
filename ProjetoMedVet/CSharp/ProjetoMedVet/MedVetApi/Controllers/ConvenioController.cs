using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LinqKit;
using MedVet.Domain.EF;
using MedVet.Poco;
using MedVet.Service.Veterinaria;

namespace MedVetApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/veterinaria/[controller]")]
    [ApiController]
    public class ConvenioController : ControllerBase
    {
        private ConvenioServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public ConvenioController(MedVetContext contexto) : base()
        {
            this.servico = new ConvenioServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros existentes na tabela Convenio
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ConvenioPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ConvenioPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com a chave primária informada.
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<ConvenioPoco> GetById(int chave)
        {
            try
            {
                ConvenioPoco poco = this.servico.PesquisarPorChave(chave);
                return Ok(poco);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a criação de um novo registro
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ConvenioPoco> Post([FromBody] ConvenioPoco poco)
        {
            try
            {
                ConvenioPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza alteração de um registro
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<ConvenioPoco> Put([FromBody] ConvenioPoco poco)
        {
            try
            {
                ConvenioPoco alteradaPoco = this.servico.Alterar(poco);
                return Ok(alteradaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a exclusão de um registro
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<ConvenioPoco> Delete(int chave)
        {
            try
            {
                ConvenioPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
