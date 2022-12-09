using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco.Viagem;
using ViajeFacil.Service.Viagem;

namespace ViajeFacilApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/viagem/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public UsuarioController(ViajeFacilContexto contexto) : base()
        {
            this.servico = new UsuarioService(contexto);
        }

        /// <summary>
        /// Retorna todos os registros da tabela Usuário
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
                return Ok(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros de acordo com o código de Endereço
        /// </summary>
        /// <param name="endid"></param>
        /// <returns></returns>
        [HttpGet("PorEnderecoId/{endid:long}")]
        public ActionResult<List<UsuarioPoco>> GetByEnderecoId(long endid)
        {
            try
            {
                List<UsuarioPoco> listaPoco = this.servico.Consultar(end => end.CodigoEndereco == endid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros de acordo com o código de TipoUsuario
        /// </summary>
        /// <param name="tipid"></param>
        /// <returns></returns>
        [HttpGet("PorTipoUsuarioId/{tipid:long}")]
        public ActionResult<List<UsuarioPoco>> GetByTipoUsuarioId(long tipid)
        {
            try
            {
                List<UsuarioPoco> listaPoco = this.servico.Consultar(tip => tip.CodigoTipoUsuario == tipid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros de acordo com o código de instituição informado
        /// </summary>
        /// <param name="insid"></param>
        /// <returns></returns>
        [HttpGet("PorInstituicaoId/{insid:long}")]
        public ActionResult<List<UsuarioPoco>> GetByInstituicaoId(long insid)
        {
            try
            {
                List<UsuarioPoco> listaPoco = this.servico.Consultar(ins => ins.CodigoInstituicao == insid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:long}")]
        public ActionResult<UsuarioPoco> GetById(long chave)
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
        /// Realiza a criação de um novo registro
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<UsuarioPoco> Post([FromBody] UsuarioPoco poco)
        {
            try
            {
                UsuarioPoco novaPoco = this.servico.Inserir(poco);
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
        /// Realiza a exclusão do registro de acordo com a chave primária informada.
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:long}")]
        public ActionResult<UsuarioPoco> Delete(long chave)
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
