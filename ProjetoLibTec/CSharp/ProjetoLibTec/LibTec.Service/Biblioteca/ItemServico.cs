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
    public class ItemServico : ServicoGenerico<Item, ItemPoco>
    {
        public ItemServico(LibTecContext contexto) : base(contexto) 
        { }

        public override List<ItemPoco> Consultar(Expression<Func<Item, bool>>? predicate = null)
        {
            IQueryable<Item> query;
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

        public override List<ItemPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Item> query;
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

        public override List<ItemPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Item, bool>>? predicate = null)
        {
            IQueryable<Item> query;
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

        public override List<ItemPoco> ConverterPara(IQueryable<Item> query)
        {
            return query.Select(ite =>
                new ItemPoco()
            {
                CodigoItem = ite.CodigoItem,
                Descricao = ite.Descricao,
                ISBN = ite.ISBN,
                Observacoes = ite.Observacoes,
                CodigoTipoItem = ite.CodigoTipoItem,
                Situacao = ite.Situacao,
                DataDeInclusao = ite.DataDeInclusao,
                DataDeAlteracao = ite.DataDeAlteracao,
                DataDeExclusao = ite.DataDeExclusao
            }).ToList();
        }
    }
}
