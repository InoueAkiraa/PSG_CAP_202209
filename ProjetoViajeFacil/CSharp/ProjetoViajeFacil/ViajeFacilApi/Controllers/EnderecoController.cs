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
    public class EnderecoController : ControllerBase
    {
        private EnderecoService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public EnderecoController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new EnderecoService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Endereco
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<EnderecoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<EnderecoPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Traz todos os registros de acordo com o código de cidade
        /// </summary>
        /// <param name="cidid"></param>
        /// <returns></returns>
        [HttpGet("PorCidade/{cidid:long}")]
        public ActionResult<List<EnderecoPoco>> GetByCidadeId(long cidid)
        {
            try
            {
                List<EnderecoPoco> listaPoco = this.servico.Consultar(cid => cid.CodigoCidade == cidid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        /// <summary>
        /// Retorna o registro de acordo com a chave primária
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:long}")]
        public ActionResult<EnderecoPoco> GetById(long chave)
        {
            try
            {
                EnderecoPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<EnderecoPoco> Post([FromBody] EnderecoPoco poco)
        {
            try
            {
                EnderecoPoco novaPoco = this.servico.Inserir(poco);
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
        public ActionResult<EnderecoPoco> Put([FromBody] EnderecoPoco poco)
        {
            try
            {
                EnderecoPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<EnderecoPoco> Delete(long chave)
        {
            try
            {
                EnderecoPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
