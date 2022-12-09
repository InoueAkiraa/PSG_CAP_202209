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
    public class InstituicaoController : ControllerBase
    {
        private InstituicaoService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public InstituicaoController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new InstituicaoService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Instituicao
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<InstituicaoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<InstituicaoPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código de endereço informado
        /// </summary>
        /// <param name="endid"></param>
        /// <returns></returns>
        [HttpGet("PorEndereço/{endid:long}")]
        public ActionResult<List<InstituicaoPoco>> GetByEnderecoId(long endid)
        {
            try
            {
                List<InstituicaoPoco> listaPoco = this.servico.Consultar(end => end.CodigoEndereco == endid).ToList();
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
        public ActionResult<InstituicaoPoco> GetById(long chave)
        {
            try
            {
                InstituicaoPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<InstituicaoPoco> Post([FromBody] InstituicaoPoco poco)
        {
            try
            {
                InstituicaoPoco novaPoco = this.servico.Inserir(poco);
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
        public ActionResult<InstituicaoPoco> Put([FromBody] InstituicaoPoco poco)
        {
            try
            {
                InstituicaoPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<InstituicaoPoco> Delete(long chave)
        {
            try
            {
                InstituicaoPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
