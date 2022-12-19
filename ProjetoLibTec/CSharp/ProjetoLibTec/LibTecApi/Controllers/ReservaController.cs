using LibTec.Domain.EF;
using LibTec.Poco;
using LibTec.Service.Biblioteca;
using LinqKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibTecApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/biblioteca/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private ReservaServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public ReservaController(LibTecContext contexto) : base()
        {
            this.servico = new ReservaServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Reserva, respeitando os parâmetros Take e Skip.
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ReservaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ReservaPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código de usuário informado.
        /// </summary>
        /// <param name="usuid"></param>
        /// <returns></returns>
        [HttpGet("porUsuarioId/{usuid:int}")]
        public ActionResult<List<ReservaPoco>> GetByUsuarioId(int usuid)
        {
            try
            {
                List<ReservaPoco> listaPoco;
                var predicado = PredicateBuilder.New<Reserva>(true);
                predicado = predicado.And(e => e.CodigoUsuario == usuid);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código de Item informado.
        /// </summary>
        /// <param name="iteid"></param>
        /// <returns></returns>
        [HttpGet("porItemId/{iteid:int}")]
        public ActionResult<List<ReservaPoco>> GetByItemId(int iteid)
        {
            try
            {
                List<ReservaPoco> listaPoco;
                var predicado = PredicateBuilder.New<Reserva>(true);
                predicado = predicado.And(e => e.CodigoItem == iteid);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código do status da Reserva informado.
        /// </summary>
        /// <param name="staid"></param>
        /// <returns></returns>
        [HttpGet("porStatusReservaId/{staid:int}")]
        public ActionResult<List<ReservaPoco>> GetByStatusReservaId(int staid)
        {
            try
            {
                List<ReservaPoco> listaPoco;
                var predicado = PredicateBuilder.New<Reserva>(true);
                predicado = predicado.And(e => e.CodigoStatus == staid);
                listaPoco = this.servico.Consultar(predicado);
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
        public ActionResult<ReservaPoco> GetById(int chave)
        {
            try
            {
                ReservaPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<ReservaPoco> Post([FromBody] ReservaPoco poco)
        {
            try
            {
                ReservaPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a alteração de um registro existente.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<ReservaPoco> Put([FromBody] ReservaPoco poco)
        {
            try
            {
                ReservaPoco alteradaPoco = this.servico.Alterar(poco);
                return Ok(alteradaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a exclusao de um registro existente de acordo com a chave primária informada.
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<ReservaPoco> Delete(int chave)
        {
            try
            {
                ReservaPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
