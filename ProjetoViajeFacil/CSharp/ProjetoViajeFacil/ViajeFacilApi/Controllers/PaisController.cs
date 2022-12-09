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
    public class PaisController : ControllerBase
    {
        private PaisService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public PaisController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new PaisService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Pais
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<PaisPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<PaisPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o nome informado.
        /// </summary>
        /// <param name="porNome"></param>
        /// <returns></returns>
        [HttpGet("{porNome}")]
        public ActionResult<List<PaisPoco>> GetByNome(string porNome)
        {
            try
            {
                List<PaisPoco> listaPoco = this.servico.Consultar(nome => nome.Nome == porNome).ToList();
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
        public ActionResult<PaisPoco> GetById(long chave)
        {
            try
            {
                PaisPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<PaisPoco> Post([FromBody] PaisPoco poco)
        {
            try
            {
                PaisPoco novaPoco = this.servico.Inserir(poco);
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
        public ActionResult<PaisPoco> Put([FromBody] PaisPoco poco)
        {
            try
            {
                PaisPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<PaisPoco> Delete(long chave)
        {
            try
            {
                PaisPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
