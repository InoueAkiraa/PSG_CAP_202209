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
    public class EnderecoController : ControllerBase
    {
        private EnderecoServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public EnderecoController(MedVetContext contexto) : base()
        {
            this.servico = new EnderecoServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros existentes na tabela Endereco
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<EnderecoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<EnderecoPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o CEP informado.
        /// </summary>
        /// <param name="porCEP"></param>
        /// <returns></returns>
        [HttpGet("{porCEP}")]
        public ActionResult<EnderecoPoco> GetByCEP(string porCEP)
        {
            try
            {
                List<EnderecoPoco> listaPoco;
                var predicado = PredicateBuilder.New<Endereco>(true);
                predicado = predicado.And(s => s.CEP == porCEP);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código de Cidade informado.
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        [HttpGet("porCidadeId/{cid:int}")]
        public ActionResult<EnderecoPoco> GetByCidadeId(int cid)
        {
            try
            {
                List<EnderecoPoco> listaPoco;
                var predicado = PredicateBuilder.New<Endereco>(true);
                predicado = predicado.And(s => s.CodigoCidade == cid);
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
        public ActionResult<EnderecoPoco> GetById(int chave)
        {
            try
            {
                EnderecoPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<EnderecoPoco> Post([FromBody] EnderecoPoco poco)
        {
            try
            {
                EnderecoPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<EnderecoPoco> Put([FromBody] EnderecoPoco poco)
        {
            try
            {
                EnderecoPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<EnderecoPoco> Delete(int chave)
        {
            try
            {
                EnderecoPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
