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
    public class EstadoController : ControllerBase
    {
        private EstadoService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public EstadoController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new EstadoService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Estado
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<EstadoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<EstadoPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com código da região informada
        /// </summary>
        /// <param name="regid"></param>
        /// <returns></returns>
        [HttpGet("PorRegião/{regid:long}")]
        public ActionResult<List<EstadoPoco>> GetByRegiaoId(long regid)
        {
            try
            {
                List<EstadoPoco> listaPoco = this.servico.Consultar(reg => reg.CodigoRegiao == regid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com a sigla do Estado
        /// </summary>
        /// <param name="siglaUF"></param>
        /// <returns></returns>
        [HttpGet("porSigla/{siglaUF}")]
        public ActionResult<List<EstadoPoco>> GetBySigla(string siglaUF)
        {
            try
            {
                List<EstadoPoco> listaPoco = this.servico.Consultar(name => name.SiglaUF == siglaUF).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o nome do Estado
        /// </summary>
        /// <param name="NomeCompleto"></param>
        /// <returns></returns>
        [HttpGet("porNome/{NomeCompleto}")]
        public ActionResult<List<EstadoPoco>> GetByNome(string NomeCompleto)
        {
            try
            {
                List<EstadoPoco> listaPoco = this.servico.Consultar(name => name.Nome == NomeCompleto).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }        

        /// <summary>
        /// Realiza a pesquisa de acordo com a chave primária informada.
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:long}")]
        public ActionResult<EstadoPoco> GetById(long chave)
        {
            try
            {
                EstadoPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<EstadoPoco> Post([FromBody] EstadoPoco poco)
        {
            try
            {
                EstadoPoco novaPoco = this.servico.Inserir(poco);
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
        public ActionResult<EstadoPoco> Put([FromBody] EstadoPoco poco)
        {
            try
            {
                EstadoPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<EstadoPoco> Delete(long chave)
        {
            try
            {
                EstadoPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
