using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco.Viagem;
using ViajeFacil.Service.Viagem;

namespace ViajeFacilApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/viagem/[controller]")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private RegiaoService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public RegiaoController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new RegiaoService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Regiao
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<RegiaoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<RegiaoPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros de acordo com o código de país informado
        /// </summary>
        /// <param name="paiid"></param>
        /// <returns></returns>
        [HttpGet("PorPaísId/{paiid:long}")]
        public ActionResult<List<RegiaoPoco>> GetByPaisId(long paiid)
        {
            try
            {
                List<RegiaoPoco> listaPoco = this.servico.Consultar(pai => pai.CodigoPais == paiid).ToList();
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
        [HttpGet("{chave:long}")]
        public ActionResult<RegiaoPoco> GetById(long chave)
        {
            try
            {
                RegiaoPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<RegiaoPoco> Post([FromBody] RegiaoPoco poco)
        {
            try
            {
                RegiaoPoco novaPoco = this.servico.Inserir(poco);
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
        public ActionResult<RegiaoPoco> Put([FromBody] RegiaoPoco poco)
        {
            try
            {
                RegiaoPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<RegiaoPoco> Delete(long chave)
        {
            try
            {
                RegiaoPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
