using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViajeFacil.Dominio.EF;
using ViajeFacil.Service.Viagem;

using ViajeFacil.Poco.Viagem;
using LinqKit;
//TO DO LIST >> criar um método que faça a procura pelo estado e pela letra que começa a cidade

namespace ViajeFacilApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/viagem/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private CidadeService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public CidadeController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new CidadeService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Cidade ou realiza a paginação
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
        /// Retorna todos os registros do Estado específicado
        /// </summary>
        /// <param name="porSigla"></param>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet("{porSigla}")]
        public ActionResult<List<CidadePoco>> GetBySigla(string porSigla, int? take = null, int? skip = null)
        {
            try
            {
                List<CidadePoco> listaPoco;
                var predicado = PredicateBuilder.New<Cidade>(true);
                if (take == null)
                {
                    if (skip != null)
                    {
                        return BadRequest("Informe os parâmetros Take e Skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.SiglaUF == porSigla);
                        listaPoco = this.servico.Consultar(predicado);
                        return Ok(listaPoco);
                    }
                }
                else
                {
                    if (skip == null)
                    {
                        return BadRequest("Informe os parâmetros Take e Skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.SiglaUF == porSigla);
                        listaPoco = this.servico.Vasculhar(take, skip, predicado);
                        return Ok(listaPoco);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a pesquisa pela sigla e pela chave informada
        /// </summary>
        /// <param name="porSigla"></param>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{porSigla}/{chave:long}")]
        public ActionResult<CidadePoco> GetBySiglaById(string porSigla, long chave)
        {
            try
            {
                List<CidadePoco> listaPoco;
                var predicado = PredicateBuilder.New<Cidade>(true);
                predicado = predicado.And(s => s.SiglaUF == porSigla);
                predicado = predicado.And(s => s.CodigoCidade == chave);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        /// <summary>
        /// Realiza a consulta de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:long}")]
        public ActionResult<CidadePoco> GetById(long chave)
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
        public ActionResult<CidadePoco> Post([FromBody]CidadePoco poco)
        {
            try
            {
                CidadePoco novaPoco = this.servico.Inserir(poco);
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
        /// Realiza a exclusão do registro de acordo com a chave primária informada.
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:long}")]
        public ActionResult<CidadePoco> Delete(long chave)
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
