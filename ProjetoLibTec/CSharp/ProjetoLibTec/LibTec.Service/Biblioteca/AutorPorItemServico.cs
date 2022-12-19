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
    public class AutorPorItemServico : ServicoGenerico<AutorPorItem, AutorPorItemPoco>
    {
        public AutorPorItemServico(LibTecContext contexto) : base(contexto) 
        { }

        public override List<AutorPorItemPoco> Consultar(Expression<Func<AutorPorItem, bool>>? predicate = null)
        {
            IQueryable<AutorPorItem> query;
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

        public override List<AutorPorItemPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<AutorPorItem> query;
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

        public override List<AutorPorItemPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<AutorPorItem, bool>>? predicate = null)
        {
            IQueryable<AutorPorItem> query;
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

        public override List<AutorPorItemPoco> ConverterPara(IQueryable<AutorPorItem> query)
        {
            return query.Select(aut =>
                new AutorPorItemPoco()
            {
                CodigoAutorPorItem = aut.CodigoAutorPorItem,
                CodigoAutor = aut.CodigoAutor,
                CodigoItem = aut.CodigoItem,
                Situacao = aut.Situacao,
                DataDeInclusao = aut.DataDeInclusao,
                DataDeAlteracao = aut.DataDeAlteracao,
                DataDeExclusao = aut.DataDeExclusao
            }).ToList();
        }
    }
}
