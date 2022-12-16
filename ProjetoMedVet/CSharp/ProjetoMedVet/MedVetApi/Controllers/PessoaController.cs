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
    public class PessoaController : ControllerBase
    {
        private PessoaServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public PessoaController(MedVetContext contexto) : base()
        {
            this.servico = new PessoaServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros dependendo da função informada.
        /// </summary>
        /// <param name="porFuncao"></param>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet("{porFuncao}")]
        public ActionResult<List<PessoaPoco>> GetAll(char porFuncao, int? take = null, int? skip = null)
        {
            try
            {
                List<PessoaPoco> listPoco;
                var predicado = PredicateBuilder.New<Pessoa>(true);
                if (take == null) //OPCIONAL
                {
                    if (skip != null)
                    {
                        return BadRequest("Informe os parâmetros take e skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.SiglaTipoPessoa == porFuncao);
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
                        predicado = predicado.And(s => s.SiglaTipoPessoa == porFuncao);
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
        /// Retorna os registros de acordo com o sexo e a função informada
        /// </summary>
        /// <param name="porSexo"></param>
        /// /// <param name="porFuncao"></param>
        /// <returns></returns>
        [HttpGet("{porSexo}/{porFuncao}")]
        public ActionResult<PessoaPoco> GetBySexo(char porSexo, char porFuncao)
        {
            try
            {
                List<PessoaPoco> listaPoco;
                var predicado = PredicateBuilder.New<Pessoa>(true);
                predicado = predicado.And(s => s.Sexo == porSexo);
                predicado = predicado.And(s => s.SiglaTipoPessoa == porFuncao);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código de TipoPessoa informado.
        /// </summary>
        /// <param name="tipid"></param>
        /// <returns></returns>
        [HttpGet("porTipoPessoaId/{tipid:int}")]
        public ActionResult<PessoaPoco> GetByTipoPessoaId(int tipid)
        {
            try
            {
                List<PessoaPoco> listPoco = this.servico.Consultar(s => (s.CodigoTipoPessoa == tipid));
                return Ok(listPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código de Endereço informado.
        /// </summary>
        /// <param name="endid"></param>
        /// <returns></returns>
        [HttpGet("porEnderecoId/{endid:int}")]
        public ActionResult<PessoaPoco> GetByEnderecoId(int endid)
        {
            try
            {
                List<PessoaPoco> listPoco = this.servico.Consultar(s => (s.CodigoEndereco == endid));
                return Ok(listPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro caso a chave primária e a sigla batem de acordo com os dados informados
        /// </summary>
        /// <param name="porFuncao"></param>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{porFuncao}/{chave:int}")]
        public ActionResult<PessoaPoco> GetById(char porFuncao, int chave)
        {
            try
            {
                List<PessoaPoco> listPoco = this.servico.Consultar(s => (s.SiglaTipoPessoa == porFuncao) && (s.CodigoPessoa == chave));
                return Ok(listPoco);
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
