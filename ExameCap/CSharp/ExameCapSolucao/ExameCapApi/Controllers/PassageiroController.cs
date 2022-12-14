using ExameCap.Dominio.EF;
using ExameCap.Poco;
using ExameCap.Service.Exame;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExameCapApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/exame/[controller]")]
    [ApiController]
    public class PassageiroController : ControllerBase
    {
        private PassageiroService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public PassageiroController(ExameCapContexto contexto) : base()
        {
            this.servico = new PassageiroService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros de Passageiro
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<PessoaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<PessoaPoco> listaPoco = this.servico.Listar(take, skip);
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
        [HttpGet("{chave:int}")]
        public ActionResult<PessoaPoco> GetByFuncionarioId(int chave)
        {
            try
            {
                PessoaPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<PessoaPoco> Post([FromBody] PessoaPoco poco)
        {
            try
            {
                PessoaPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<PessoaPoco> Put([FromBody] PessoaPoco poco)
        {
            try
            {
                PessoaPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<PessoaPoco> DeleteById(int chave)
        {
            try
            {
                PessoaPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
