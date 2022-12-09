using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco.Viagem;
using ViajeFacil.Service.Viagem;

namespace ViajeFacilApi.Controllers
{
    [Route("api/viagem/[controller]")]
    [ApiController]
    public class RotaController : ControllerBase
    {
        private RotaService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public RotaController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new RotaService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Rota
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<RotaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<RotaPoco> listaPoco = this.servico.Listar(take, skip);
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
        public ActionResult<RotaPoco> GetById(long chave)
        {
            try
            {
                RotaPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<RotaPoco> Post([FromBody] RotaPoco poco)
        {
            try
            {
                RotaPoco novaPoco = this.servico.Inserir(poco);
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
        public ActionResult<RotaPoco> Put([FromBody] RotaPoco poco)
        {
            try
            {
                RotaPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<RotaPoco> Delete(long chave)
        {
            try
            {
                RotaPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
