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
    public class TipoPessoaController : ControllerBase
    {
        private TipoPessoaServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public TipoPessoaController(MedVetContext contexto) : base()
        {
            this.servico = new TipoPessoaServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros existentes na tabela TipoPessoa
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<TipoPessoaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<TipoPessoaPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com a sigla informada
        /// </summary>
        /// <param name="sigla"></param>
        /// <returns></returns>
        [HttpGet("porSigla/{sigla}")]
        public ActionResult<List<TipoPessoaPoco>> GetBySiglaTipoPessoa(char sigla)
        {
            try
            {
                List<TipoPessoaPoco> listaPoco;
                var predicado = PredicateBuilder.New<TipoPessoa>(true);
                predicado = predicado.And(s => s.SiglaTipoPessoa == sigla);
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
        public ActionResult<TipoPessoaPoco> GetById(int chave)
        {
            try
            {
                TipoPessoaPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<TipoPessoaPoco> Post([FromBody] TipoPessoaPoco poco)
        {
            try
            {
                TipoPessoaPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<TipoPessoaPoco> Put([FromBody] TipoPessoaPoco poco)
        {
            try
            {
                TipoPessoaPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<TipoPessoaPoco> Delete(int chave)
        {
            try
            {
                TipoPessoaPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
