using LibTec.Domain.EF;
using LibTec.Poco;
using LibTec.Service.Biblioteca;
using LinqKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibTecApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/biblioteca/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private ItemServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public ItemController(LibTecContext contexto) : base()
        {
            this.servico = new ItemServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Item, respeitando parâmetros Take e Skip
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ItemPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ItemPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código ISBN informado. (Exige modificações no banco de dados para o funcionamento)
        /// </summary>
        /// <param name="porCodigoISBN"></param>
        /// <returns></returns>
        [HttpGet("{porCodigoISBN}")]
        public ActionResult<ItemPoco> GetByCodigoISBN(string porCodigoISBN)
        {
            try
            {
                ItemPoco poco;                
                poco = this.servico.Consultar(it => it.ISBN.Contains(porCodigoISBN)).First();
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna os registros de acordo com o código de TipoItem informado.
        /// </summary>
        /// <param name="tipid"></param>
        /// <returns></returns>
        [HttpGet("porTipoItemId/{tipid:int}")]
        public ActionResult<List<ItemPoco>> GetByTipoItemId(int tipid)
        {
            try
            {
                List<ItemPoco> listaPoco;
                var predicado = PredicateBuilder.New<Item>(true);
                predicado = predicado.And(e => e.CodigoTipoItem == tipid);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código da chave primária informada.
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<ItemPoco> GetById(int chave)
        {
            try
            {
                ItemPoco poco = this.servico.PesquisarPorChave(chave);
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
        public ActionResult<ItemPoco> Post([FromBody] ItemPoco poco)
        {
            try
            {
                ItemPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a alteração de um registro existente.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<ItemPoco> Put([FromBody] ItemPoco poco)
        {
            try
            {
                ItemPoco alteradaPoco = this.servico.Alterar(poco);
                return Ok(alteradaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a exclusao de um registro existente de acordo com a chave primária informada.
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<ItemPoco> Delete(int chave)
        {
            try
            {
                ItemPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
