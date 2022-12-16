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
    public class AtendenteController : ControllerBase
    {
        private PessoaServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public AtendenteController(MedVetContext contexto) : base()
        {
            this.servico = new PessoaServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros em que as pessoas sejam atendentes.
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<PessoaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<PessoaPoco> listPoco;
                var predicado = PredicateBuilder.New<Pessoa>(true);
                if (take == null)
                {
                    if (skip != null)
                    {
                        return BadRequest("Informe os parâmetros take e skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.SiglaTipoPessoa == 'A');
                        listPoco = this.servico.Consultar(predicado);
                        return Ok(listPoco);
                    }
                }
                else
                {
                    if (skip == null) //OPCIONAL
                    {
                        return BadRequest("Informe os parâmetros take e skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.SiglaTipoPessoa == 'A');
                        listPoco = this.servico.Vasculhar(take, skip, predicado);
                        return Ok(listPoco);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna os registros de acordo com o sexo informado
        /// </summary>
        /// <param name="porSexo"></param>
        /// <returns></returns>
        [HttpGet("{porSexo}")]
        public ActionResult<PessoaPoco> GetBySexo(char porSexo)
        {
            try
            {
                List<PessoaPoco> listaPoco;
                var predicado = PredicateBuilder.New<Pessoa>(true);
                predicado = predicado.And(s => s.Sexo == porSexo);
                predicado = predicado.And(s => s.SiglaTipoPessoa == 'A');
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com a chave informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<PessoaPoco> GetById(int chave)
        {
            try
            {
                List<PessoaPoco> listaPoco;
                var predicado = PredicateBuilder.New<Pessoa>(true);
                predicado = predicado.And(s => s.SiglaTipoPessoa == 'A');
                predicado = predicado.And(s => s.CodigoPessoa == chave);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
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
        public ActionResult<PessoaPoco> Post([FromBody] PessoaPoco poco)
        {
            try
            {
                PessoaPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<PessoaPoco> Put([FromBody] PessoaPoco poco)
        {
            try
            {
                PessoaPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<PessoaPoco> Delete(int chave)
        {
            try
            {
                PessoaPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
