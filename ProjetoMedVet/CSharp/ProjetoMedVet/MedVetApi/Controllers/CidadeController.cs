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
    public class CidadeController : ControllerBase
    {
        private CidadeServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public CidadeController(MedVetContext contexto) : base()
        {
            this.servico = new CidadeServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros existentes na tabela Cidade
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<CidadePoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<CidadePoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o nome informado
        /// </summary>
        /// <param name="porNome"></param>
        /// <returns></returns>
        [HttpGet("{porNome}")]
        public ActionResult<CidadePoco> GetByNome(string porNome)
        {
            try
            {
                List<CidadePoco> listaPoco;
                var predicado = PredicateBuilder.New<Cidade>(true);
                predicado = predicado.And(s => s.Nome == porNome);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código IBGE7 informado.
        /// </summary>
        /// <param name="ibge7"></param>
        /// <returns></returns>
        [HttpGet("porCodigoIBGE7/{ibge7:int}")]
        public ActionResult<CidadePoco> GetByCodigoIBGE7(int ibge7)
        {
            try
            {
                List<CidadePoco> listaPoco;
                var predicado = PredicateBuilder.New<Cidade>(true);
                predicado = predicado.And(s => s.CodigoIBGE7 == ibge7);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna os registros de acordo com o código de Estado informado.
        /// </summary>
        /// <param name="estid"></param>
        /// <returns></returns>
        [HttpGet("porEstadoId/{estid:int}")]
        public ActionResult<CidadePoco> GetByEstadoId(int estid)
        {
            try
            {
                List<CidadePoco> listaPoco;
                var predicado = PredicateBuilder.New<Cidade>(true);
                predicado = predicado.And(s => s.CodigoEstado == estid);
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
        public ActionResult<CidadePoco> GetById(int chave)
        {
            try
            {
                CidadePoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<CidadePoco> Post([FromBody] CidadePoco poco)
        {
            try
            {
                CidadePoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<CidadePoco> Put([FromBody] CidadePoco poco)
        {
            try
            {
                CidadePoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<CidadePoco> Delete(int chave)
        {
            try
            {
                CidadePoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
