using LibTec.Domain.EF;
using LibTec.Poco;
using LibTec.Service.Biblioteca;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LinqKit;

namespace LibTecApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/biblioteca/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public UsuarioController(LibTecContext contexto) : base()
        {
            this.servico = new UsuarioServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Usuario, respeitando parâmetros Take e Skip.
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<UsuarioPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<UsuarioPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o nome e o sobrenome informados.
        /// </summary>
        /// <param name="porNome"></param>
        /// <param name="porSobrenome"></param>
        /// <returns></returns>
        [HttpGet("{porNome}/{porSobrenome}")]
        public ActionResult<List<UsuarioPoco>> GetByNomeSobrenome(string porNome, string porSobrenome)
        {
            try
            {
                List<UsuarioPoco> listaPoco;
                var predicado = PredicateBuilder.New<Usuario>(true);
                predicado = predicado.And(e => e.Nome == porNome);
                predicado = predicado.And(e => e.Sobrenome == porSobrenome);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o e-mail informado.
        /// </summary>
        /// <param name="porEmail"></param>
        /// <returns></returns>
        [HttpGet("{porEmail}")]
        public ActionResult<List<UsuarioPoco>> GetByEmail(string porEmail)
        {
            try
            {
                List<UsuarioPoco> listaPoco;
                var predicado = PredicateBuilder.New<Usuario>(true);
                predicado = predicado.And(e => e.Email == porEmail);
                listaPoco = this.servico.Consultar(predicado);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código de TipoUsuario solicitado.
        /// </summary>
        /// <param name="tipid"></param>
        /// <returns></returns>
        [HttpGet("porTipoUsuario/{tipid:int}")]
        public ActionResult<List<UsuarioPoco>> GetByTipoUsuarioId(int tipid)
        {
            try
            {
                List<UsuarioPoco> listaPoco;
                var predicado = PredicateBuilder.New<Usuario>(true);
                predicado = predicado.And(e => e.CodigoTipoUsuario == tipid);
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
        public ActionResult<UsuarioPoco> GetById(int chave)
        {
            try
            {
                UsuarioPoco poco = this.servico.PesquisarPorChave(chave);                
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a criação de um novo registro.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<UsuarioPoco> Post([FromBody] UsuarioPoco poco)
        {
            try
            {
                UsuarioPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<UsuarioPoco> Put([FromBody] UsuarioPoco poco)
        {
            try
            {
                UsuarioPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<UsuarioPoco> Delete(int chave)
        {
            try
            {
                UsuarioPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
