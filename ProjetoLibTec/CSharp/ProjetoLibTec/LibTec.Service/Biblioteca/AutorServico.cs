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
    public class AutorServico : ServicoGenerico<Autor, AutorPoco>
    {
        public AutorServico(LibTecContext contexto) : base(contexto) 
        { }

        public override List<AutorPoco> Consultar(Expression<Func<Autor, bool>>? predicate = null)
        {
            IQueryable<Autor> query;
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

        public override List<AutorPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Autor> query;
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

        public override List<AutorPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Autor, bool>>? predicate = null)
        {
            IQueryable<Autor> query;
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

        public override List<AutorPoco> ConverterPara(IQueryable<Autor> query)
        {
            return query.Select(aut =>
                new AutorPoco()
            {
                CodigoAutor = aut.CodigoAutor,
                Nome = aut.Nome,
                Situacao = aut.Situacao,
                DataDeInclusao = aut.DataDeInclusao,
                DataDeAlteracao = aut.DataDeAlteracao,
                DataDeExclusao = aut.DataDeExclusao
            }).ToList();
        }
    }
}
