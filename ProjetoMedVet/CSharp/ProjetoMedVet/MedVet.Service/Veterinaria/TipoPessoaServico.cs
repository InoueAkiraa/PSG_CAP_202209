using MedVet.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MedVet.Domain.EF;
using MedVet.Poco;
using System.Linq.Expressions;

namespace MedVet.Service.Veterinaria
{
    public class TipoPessoaServico : ServicoGenerico<TipoPessoa, TipoPessoaPoco>
    {
        public TipoPessoaServico(MedVetContext contexto) : base(contexto)
        { }

        public override List<TipoPessoaPoco> Consultar(Expression<Func<TipoPessoa, bool>>? predicate = null)
        {
            IQueryable<TipoPessoa> query;
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

        public override List<TipoPessoaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<TipoPessoa> query;
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

        public override List<TipoPessoaPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<TipoPessoa, bool>>? predicate = null)
        {
            IQueryable<TipoPessoa> query;
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

        public override List<TipoPessoaPoco> ConverterPara(IQueryable<TipoPessoa> query)
        {
            return query.Select(tip =>
                new TipoPessoaPoco()
            {
                CodigoTipoPessoa = tip.CodigoTipoPessoa,
                SiglaTipoPessoa = tip.SiglaTipoPessoa,
                Descricao = tip.Descricao,
                Situacao = tip.Situacao,
                DataDeInsercao = tip.DataDeInsercao,
                DataDeAlteracao = tip.DataDeAlteracao,
                DataDeExclusao = tip.DataDeExclusao
            }).ToList();
        }
    }
}
