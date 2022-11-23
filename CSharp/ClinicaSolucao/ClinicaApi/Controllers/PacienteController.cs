using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Clinica.Dominio.EF;
using Clinica.Poco.Odonto;
using Clinica.Servico.Odonto;

namespace ClinicaApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/clinica/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private PacienteServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public PacienteController(ClinicaContext contexto) : base()
        {
            this.servico = new PacienteServico(contexto);
        }

        /// <summary>
        /// Listar todos os registros da tabela Paciente.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<PacientePoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<PacientePoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Paciente de acordo com o código de Profissão informado.
        /// </summary>
        /// <param name="proid"></param>
        /// <returns></returns>
        [HttpGet("PorProfissao/{proid:int}")]
        public ActionResult<List<PacientePoco>> GetPorProfissao(int proid)
        {
            try
            {
                List<PacientePoco> listaPoco = this.servico.Consultar(pro => pro.CodigoProfissao == proid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista o registro da tabela Paciente de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<PacientePoco> GetById(int chave)
        {
            try
            {
                PacientePoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<PacientePoco> Post([FromBody] PacientePoco poco)
        {
            try
            {
                PacientePoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<PacientePoco> Put([FromBody] PacientePoco poco)
        {
            try
            {
                PacientePoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<PacientePoco> DeleteById(int chave)
        {
            try
            {
                PacientePoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
