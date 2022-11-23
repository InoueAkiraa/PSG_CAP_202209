using Clinica.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Clinica.Dominio.EF;
using Clinica.Poco.Odonto;


namespace ClinicaApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/clinica/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        public ConsultaServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public ConsultaController(ClinicaContext contexto) : base()
        {
            this.servico = new ConsultaServico(contexto);
        }

        /// <summary>
        /// Devolve todos os registros da tabela Consulta
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ConsultaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ConsultaPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Consulta o registro se baseando na chave primária
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<ConsultaPoco> GetById(int chave)
        {
            try
            {
                ConsultaPoco poco = this.servico.PesquisarPorChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a criação de um novo registro através de uma instância
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ConsultaPoco> Post([FromBody] ConsultaPoco poco)
        {
            try
            {
                ConsultaPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<ConsultaPoco> Put([FromBody] ConsultaPoco poco)
        {
            try
            {
                ConsultaPoco pocoEditado = this.servico.Alterar(poco);
                return Ok(pocoEditado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza exclusão de um registro se baseando em sua chave primária
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<ConsultaPoco> Delete(int chave)
        {
            try
            {
                ConsultaPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
