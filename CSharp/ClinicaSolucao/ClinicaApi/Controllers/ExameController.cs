﻿using Clinica.Dominio.EF;
using Clinica.Poco.Odonto;
using Clinica.Servico.Odonto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

using LinqKit;

namespace ClinicaApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/clinica/[controller]")]
    [ApiController]
    public class ExameController : ControllerBase
    {
        private ProcedimentosServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public ExameController(ClinicaContext contexto) : base() 
        {
            this.servico = new ProcedimentosServico(contexto);
        }

        /// <summary>
        /// Retorna todos os registros que sejam do tipo Exame
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ServicoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ServicoPoco> listaPoco;
                var predicado = PredicateBuilder.New<Clinica.Dominio.EF.Servico>(true);                
                if (take == null)
                {
                    if (skip != null)
                    {
                        return BadRequest("Informe os parâmetros Take e Skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.TipoServico == "EX");
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
                        predicado = predicado.And(s => s.TipoServico == "EX");
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
        /// Retorna o registro de acordo com a chave informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<ServicoPoco> GetById(int chave)
        {
            try
            {
                List<ServicoPoco> listaPoco;
                var predicado = PredicateBuilder.New<Clinica.Dominio.EF.Servico>(true);
                predicado = predicado.And(s => s.TipoServico == "EX");
                predicado = predicado.And(s => s.CodigoServico == chave);                
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
        public ActionResult<ServicoPoco> Post([FromBody] ServicoPoco poco)
        {
            try
            {
                ServicoPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<ServicoPoco> Put([FromBody] ServicoPoco poco)
        {
            try
            {
                ServicoPoco alteradaPoco = this.servico.Alterar(poco);
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
        public ActionResult<ServicoPoco> Delete(int chave)
        {
            try
            {
                ServicoPoco delPoco = this.servico.Excluir(chave);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
