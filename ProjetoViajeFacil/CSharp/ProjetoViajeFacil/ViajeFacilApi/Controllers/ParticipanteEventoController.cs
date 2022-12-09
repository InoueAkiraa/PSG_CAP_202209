using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViajeFacil.Dominio.EF;
using ViajeFacil.Service.Viagem;
using ViajeFacil.Poco.Viagem;

namespace ViajeFacilApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/viagem/[controller]")]
    [ApiController]
    public class ParticipanteEventoController : ControllerBase
    {
        private ParticipanteEventoService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public ParticipanteEventoController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new ParticipanteEventoService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela ParticipanteEvento
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ParticipanteEventoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ParticipanteEventoPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros de acordo com o código de Evento informado
        /// </summary>
        /// <param name="eveid"></param>
        /// <returns></returns>
        [HttpGet("PorEventoId/{eveid:long}")]
        public ActionResult<List<ParticipanteEventoPoco>> GetByEventoId(long eveid)
        {
            try
            {
                List<ParticipanteEventoPoco> listaPoco = this.servico.Consultar(eve => eve.CodigoEvento == eveid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros de acordo com o código de Usuário informado
        /// </summary>
        /// <param name="usuid"></param>
        /// <returns></returns>
        [HttpGet("PorUsuarioId/{usuid:long}")]
        public ActionResult<List<ParticipanteEventoPoco>> GetByUsuarioId(long usuid)
        {
            try
            {
                List<ParticipanteEventoPoco> listaPoco = this.servico.Consultar(usu => usu.CodigoUsuario == usuid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:long}")]
        public ActionResult<ParticipanteEventoPoco> GetById(long chave)
        {
            try
            {
                ParticipanteEventoPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<ParticipanteEventoPoco> Post([FromBody] ParticipanteEventoPoco poco)
        {
            try
            {
                ParticipanteEventoPoco novaPoco = this.servico.Inserir(poco);
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
        public ActionResult<ParticipanteEventoPoco> Put([FromBody] ParticipanteEventoPoco poco)
        {
            try
            {
                ParticipanteEventoPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<ParticipanteEventoPoco> Delete(long chave)
        {
            try
            {
                ParticipanteEventoPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
