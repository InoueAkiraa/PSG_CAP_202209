using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibTec.Service.Base;
using LibTec.Domain.EF;
using LibTec.Poco;
using System.Linq.Expressions;

namespace LibTec.Service.Biblioteca
{
    public class UsuarioServico : ServicoGenerico<Usuario, UsuarioPoco>
    {
        public UsuarioServico(LibTecContext contexto) : base(contexto) 
        { }

        public override List<UsuarioPoco> Consultar(Expression<Func<Usuario, bool>>? predicate = null)
        {
            IQueryable<Usuario> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }
            return this.ConverterPara(query);
        }

        public override List<UsuarioPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Usuario> query;
            if (skip == null)
            {
                query = this.genrepo.GetAll();
            }
            else
            {
                query = this.genrepo.GetAll(take, skip);
            }
            return this.ConverterPara(query);
        }

        public override List<UsuarioPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Usuario, bool>>? predicate = null)
        {
            IQueryable<Usuario> query;
            if (skip == null)
            {
                if (predicate == null)
                {
                    query = this.genrepo.Browseable(null);
                }
                else
                {
                    query = this.genrepo.Browseable(predicate);
                }
            }
            else
            {
                if (predicate == null)
                {
                    query = this.genrepo.GetAll(take, skip);
                }
                else
                {
                    query = this.genrepo.Searchable(take, skip, predicate);
                }
            }
            return this.ConverterPara(query);
        }

        public override List<UsuarioPoco> ConverterPara(IQueryable<Usuario> query)
        {
            return query.Select(usu =>
                new UsuarioPoco()
            {
                CodigoUsuario = usu.CodigoUsuario,
                Nome = usu.Nome,
                Sobrenome = usu.Sobrenome,
                Senha = usu.Senha,
                Email = usu.Email,
                MaxEmprestimos = usu.MaxEmprestimos,
                CodigoTipoUsuario = usu.CodigoTipoUsuario,
                Situacao = usu.Situacao,
                DataDeInclusao = usu.DataDeInclusao,
                DataDeAlteracao = usu.DataDeAlteracao,
                DataDeExclusao = usu.DataDeAlteracao
            }).ToList();
        }
    }
}
