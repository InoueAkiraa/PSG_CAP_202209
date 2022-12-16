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
    public class TipoAtendimentoController : ControllerBase
    {
        private TipoAtendimentoServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public TipoAtendimentoController(MedVetContext contexto) : base()
        {
            this.servico = new TipoAtendimentoServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros existentes na tabela TipoAtendimento
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<TipoAtendimentoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<TipoAtendimentoPoco> listaPoco = this.servico.Listar(take, skip);
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
        public ActionResult<List<TipoAtendimentoPoco>> GetBySiglaTipoPessoa(char sigla)
        {
            try
            {
                List<TipoAtendimentoPoco> listaPoco;
                var predicado = PredicateBuilder.New<TipoAtendimento>(true);
                predicado = predicado.And(s => s.SiglaTipoAtendimento == sigla);
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
        public ActionResult<TipoAtendimentoPoco> GetById(int chave)
        {
            try
            {
                TipoAtendimentoPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<TipoAtendimentoPoco> Post([FromBody] TipoAtendimentoPoco poco)
        {
            try
            {
                TipoAtendimentoPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<TipoAtendimentoPoco> Put([FromBody] TipoAtendimentoPoco poco)
        {
            try
            {
                TipoAtendimentoPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<TipoAtendimentoPoco> Delete(int chave)
        {
            try
            {
                TipoAtendimentoPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
