using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;
using Atacado.DB.EF.Database;

namespace AtacadoApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class SubcategoriaController : ControllerBase
    {
        private SubcategoriaServico servico;

        /// <summary>
        /// 
        /// </summary>
        public SubcategoriaController(ProjetoAcademiaContext context) : base()
        {
            this.servico = new SubcategoriaServico(context);
        }

        /// <summary>
        /// Listar todos os registros da tabela Subcategoria.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<SubcategoriaPoco>> GetAll()
        {
            try
            {
                List <SubcategoriaPoco> listaPoco = this.servico.Listar();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            
        }

        /// <summary>
        /// Listar todos os registros da tabela Subcategoria de acordo com o código de Categoria informado.
        /// </summary>
        /// <param name="catid">Código da categoria (chave estrangeira) da tabela Subcategoria</param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public ActionResult<List<SubcategoriaPoco>> GetPorCategoria(int catid)
        {
            try
            {
                List<SubcategoriaPoco> listaPoco = this.servico.Consultar(sub => sub.CodigoCategoria == catid).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }            
        }

        /// <summary>
        /// Lista o registro da tabela Subcategoria de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave">chave primária da tabela</param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<SubcategoriaPoco> GetById(int chave)
        {
            try
            {
                SubcategoriaPoco poco = this.servico.PesquisarPorChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a criação de um registro através de uma instância
        /// </summary>
        /// <param name="poco">instância passada como parâmetro</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<SubcategoriaPoco> Post([FromBody] SubcategoriaPoco poco)
        {
            try
            {
                SubcategoriaPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a alteração de um registro através de uma instância
        /// </summary>
        /// <param name="poco">instância passada como parâmetro</param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<SubcategoriaPoco> Put([FromBody] SubcategoriaPoco poco)
        {
            try
            {
                SubcategoriaPoco novoPoco = this.servico.Alterar(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a exclusão de um registro de acordo com a chave primária informada
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<SubcategoriaPoco> DeleteById(int chave)
        {
            try
            {
                SubcategoriaPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Realiza a exclusão de um registro através de uma instância
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult<SubcategoriaPoco> Delete([FromBody] SubcategoriaPoco poco)
        {
            try
            {
                SubcategoriaPoco novoPoco = this.servico.Excluir(poco.Codigo);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
