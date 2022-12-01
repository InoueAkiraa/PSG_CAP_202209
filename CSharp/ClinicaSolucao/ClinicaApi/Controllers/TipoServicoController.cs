using Clinica.Dominio.EF;
using Clinica.Poco.Odonto;
using Clinica.Servico.Odonto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/clinica/[controller]")]
    [ApiController]
    public class TipoServicoController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        public TipoServicoServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public TipoServicoController(ClinicaContext contexto) : base()
        {
            this.servico = new TipoServicoServico(contexto);
        }

        /// <summary>
        /// Devolve todos os registros da tabela de TipoServico
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<TipoServicoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<TipoServicoPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Devolve o registro da tabela TipoServico pela chave primária
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<TipoServicoPoco> GetById(int chave)
        {
            try
            {
                TipoServicoPoco poco = this.servico.PesquisarPorChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza criação de um novo registro atravês da instância 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<TipoServicoPoco> Post([FromBody] TipoServicoPoco poco)
        {
            try
            {
                TipoServicoPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a alteraçao de um registro através da sua instância
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<TipoServicoPoco> Put([FromBody] TipoServicoPoco poco)
        {
            try
            {
                TipoServicoPoco alteradaPoco = this.servico.Alterar(poco);
                return Ok(alteradaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclusão de um registro através de sua chave primária
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<TipoServicoPoco> Delete(int chave)
        {
            try
            {
                TipoServicoPoco pocoExclusao = this.servico.Excluir(chave);
                return Ok(pocoExclusao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
