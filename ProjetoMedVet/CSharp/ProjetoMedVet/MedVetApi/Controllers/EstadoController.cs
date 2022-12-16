using LinqKit;
using MedVet.Domain.EF;
using MedVet.Poco;
using MedVet.Service.Veterinaria;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedVetApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/veterinaria/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private EstadoServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public EstadoController(MedVetContext contexto) : base()
        {
            this.servico = new EstadoServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros existentes na tabela Estado
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
        /// Retorna o registro de acordo com o nome informado.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpGet("porNome/{nome}")]
        public ActionResult<List<EstadoPoco>> GetByNome(string nome)
        {
            try
            {
                List<EstadoPoco> listaPoco;
                var predicado = PredicateBuilder.New<Estado>(true);
                predicado = predicado.And(s => s.Nome == nome);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com a Sigla UF informada.
        /// </summary>
        /// <param name="porSiglaUF"></param>
        /// <returns></returns>
        [HttpGet("{porSiglaUF}")]
        public ActionResult<List<EstadoPoco>> GetBySiglaUF(string porSiglaUF)
        {
            try
            {
                List<EstadoPoco> listaPoco;
                var predicado = PredicateBuilder.New<Estado>(true);
                predicado = predicado.And(s => s.SiglaUF == porSiglaUF);
                listaPoco = this.servico.Consultar(predicado);
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
        [HttpGet("{chave:int}")]
        public ActionResult<EstadoPoco> GetById(int chave)
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
                EstadoPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza alteração de um registro
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
        /// Realiza a exclusão de um registro
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<EstadoPoco> Delete(int chave)
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
