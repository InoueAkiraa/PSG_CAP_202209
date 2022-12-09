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
    public class PontoParadaController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        private PontoParadaService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public PontoParadaController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new PontoParadaService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela PontoParada
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<PontoParadaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<PontoParadaPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros de acordo com o código de rota informado
        /// </summary>
        /// <param name="rotid"></param>
        /// <returns></returns>
        [HttpGet("PorRotaId/{rotid:long}")]
        public ActionResult<List<PontoParadaPoco>> GetByRotaId(long rotid)
        {
            try
            {
                List<PontoParadaPoco> listaPoco = this.servico.Consultar(rot => rot.CodigoRota == rotid).ToList();
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
        public ActionResult<PontoParadaPoco> GetById(long chave)
        {
            try
            {
                PontoParadaPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<PontoParadaPoco> Post([FromBody] PontoParadaPoco poco)
        {
            try
            {
                PontoParadaPoco novaPoco = this.servico.Inserir(poco);
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
        public ActionResult<PontoParadaPoco> Put([FromBody] PontoParadaPoco poco)
        {
            try
            {
                PontoParadaPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<PontoParadaPoco> Delete(long chave)
        {
            try
            {
                PontoParadaPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
