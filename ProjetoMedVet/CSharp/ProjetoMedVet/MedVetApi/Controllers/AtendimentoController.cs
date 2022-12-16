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
    public class AtendimentoController : ControllerBase
    {
        private AtendimentoServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public AtendimentoController(MedVetContext contexto) : base()
        {
            this.servico = new AtendimentoServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros dependendo do atendimento informado.
        /// </summary>
        /// <param name="porTipoAtendimento"></param>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet("{porTipoAtendimento}")]
        public ActionResult<List<AtendimentoPoco>> GetAll(char porTipoAtendimento, int? take = null, int? skip = null)
        {
            try
            {
                List<AtendimentoPoco> listPoco;
                var predicado = PredicateBuilder.New<Atendimento>(true);
                if (take == null) //OPCIONAL
                {
                    if (skip != null)
                    {
                        return BadRequest("Informe os parâmetros take e skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.SiglaTipoAtendimento == porTipoAtendimento);
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
                        predicado = predicado.And(s => s.SiglaTipoAtendimento == porTipoAtendimento);
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
        /// Retorna o registro de acordo com o código do tipo de atendimento informado.
        /// </summary>
        /// <param name="tipid"></param>
        /// <returns></returns>
        [HttpGet("porTipoAtendimentoId/{tipid:int}")]
        public ActionResult<AtendimentoPoco> GetByTipoAtendimentoId(int tipid)
        {
            try
            {
                List<AtendimentoPoco> listPoco = this.servico.Consultar(s => (s.CodigoTipoAtendimento == tipid));
                return Ok(listPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código do Atendente informado.
        /// </summary>
        /// <param name="ateid"></param>
        /// <returns></returns>
        [HttpGet("porAtendenteId/{ateid:int}")]
        public ActionResult<AtendimentoPoco> GetByAtendenteId(int ateid)
        {
            try
            {
                List<AtendimentoPoco> listPoco = this.servico.Consultar(s => (s.CodigoAtendente == ateid));
                return Ok(listPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código do Paciente informado.
        /// </summary>
        /// <param name="pacid"></param>
        /// <returns></returns>
        [HttpGet("porPacienteId/{pacid:int}")]
        public ActionResult<AtendimentoPoco> GetByPacienteId(int pacid)
        {
            try
            {
                List<AtendimentoPoco> listPoco = this.servico.Consultar(s => (s.CodigoPaciente == pacid));
                return Ok(listPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código do Medico informado.
        /// </summary>
        /// <param name="medid"></param>
        /// <returns></returns>
        [HttpGet("porMedicoId/{medid:int}")]
        public ActionResult<AtendimentoPoco> GetByMedicoId(int medid)
        {
            try
            {
                List<AtendimentoPoco> listPoco = this.servico.Consultar(s => (s.CodigoMedico == medid));
                return Ok(listPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código do Enfermeiro informado.
        /// </summary>
        /// <param name="enfid"></param>
        /// <returns></returns>
        [HttpGet("porEnfermeiroId/{enfid:int}")]
        public ActionResult<AtendimentoPoco> GetByEnfermeiroId(int enfid)
        {
            try
            {
                List<AtendimentoPoco> listPoco = this.servico.Consultar(s => (s.CodigoEnfermeiro == enfid));
                return Ok(listPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna o registro de acordo com o código do Convenio informado.
        /// </summary>
        /// <param name="conid"></param>
        /// <returns></returns>
        [HttpGet("porConvenioId/{conid:int}")]
        public ActionResult<AtendimentoPoco> GetByConvenioId(int conid)
        {
            try
            {
                List<AtendimentoPoco> listPoco = this.servico.Consultar(s => (s.CodigoConvenio == conid));
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
        /// <param name="porTipoAtendimento"></param>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{porTipoAtendimento}/{chave:int}")]
        public ActionResult<AtendimentoPoco> GetById(char porTipoAtendimento, int chave)
        {
            try
            {
                List<AtendimentoPoco> listPoco = this.servico.Consultar(s => (s.SiglaTipoAtendimento == porTipoAtendimento) && (s.CodigoAtendimento == chave));
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
        public ActionResult<AtendimentoPoco> Post([FromBody] AtendimentoPoco poco)
        {
            try
            {
                AtendimentoPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<AtendimentoPoco> Put([FromBody] AtendimentoPoco poco)
        {
            try
            {
                AtendimentoPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<AtendimentoPoco> Delete(int chave)
        {
            try
            {
                AtendimentoPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
