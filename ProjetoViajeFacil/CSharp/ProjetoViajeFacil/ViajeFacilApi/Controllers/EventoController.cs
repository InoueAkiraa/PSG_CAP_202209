using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViajeFacil.Dominio.EF;
using ViajeFacil.Service.Viagem;
using ViajeFacil.Poco.Viagem;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace ViajeFacilApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/viagem/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private EventoService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public EventoController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new EventoService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Evento
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<EventoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<EventoPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros da tabela Evento pelo código de instituição informado
        /// </summary>
        /// <param name="insid"></param>
        /// <returns></returns>
        [HttpGet("PorInstituicaoId/{insid:long}")]
        public ActionResult<List<EventoPoco>> GetByInstituicaoId(long insid)
        {
            try
            {
                List<EventoPoco> listaPoco = this.servico.Consultar(ins => ins.CodigoInstituicao == insid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros da tabela Evento pelo código de endereço informado
        /// </summary>
        /// <param name="endid"></param>
        /// <returns></returns>
        [HttpGet("PorEndereço/{endid:long}")]
        public ActionResult<List<EventoPoco>> GetByEnderecoId(long endid)
        {
            try
            {
                List<EventoPoco> listaPoco = this.servico.Consultar(end => end.CodigoEndereco == endid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros da tabela Evento pelo código de usuário informado
        /// </summary>
        /// <param name="usuid"></param>
        /// <returns></returns>
        [HttpGet("PorUsuário/{usuid:long}")]
        public ActionResult<List<EventoPoco>> GetByUsuarioId(long usuid)
        {
            try
            {
                List<EventoPoco> listaPoco = this.servico.Consultar(usu => usu.CodigoUsuarioResponsavel == usuid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a consulta de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:long}")]
        public ActionResult<EventoPoco> GetById(long chave)
        {
            try
            {
                EventoPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<EventoPoco> Post([FromBody] EventoPoco poco)
        {
            try
            {
                EventoPoco novaPoco = this.servico.Inserir(poco);
                return Ok(novaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a alteração de um registro
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<EventoPoco> Put([FromBody] EventoPoco poco)
        {
            try
            {
                EventoPoco alteradaPoco = this.servico.Alterar(poco);
                return Ok(alteradaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a exclusão do registro de acordo com a chave primária informada.
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:long}")]
        public ActionResult<EventoPoco> Delete(long chave)
        {
            try
            {
                EventoPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
