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
    public class TipoAtendimentoServico : ServicoGenerico<TipoAtendimento, TipoAtendimentoPoco>
    {
        public TipoAtendimentoServico(MedVetContext contexto) : base(contexto)
        { }

        public override List<TipoAtendimentoPoco> Consultar(Expression<Func<TipoAtendimento, bool>>? predicate = null)
        {
            IQueryable<TipoAtendimento> query;
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

        public override List<TipoAtendimentoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<TipoAtendimento> query;
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

        public override List<TipoAtendimentoPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<TipoAtendimento, bool>>? predicate = null)
        {
            IQueryable<TipoAtendimento> query;
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

        public override List<TipoAtendimentoPoco> ConverterPara(IQueryable<TipoAtendimento> query)
        {
            return query.Select(tip =>
                new TipoAtendimentoPoco()
                {
                    CodigoTipoAtendimento = tip.CodigoTipoAtendimento,
                    SiglaTipoAtendimento = tip.SiglaTipoAtendimento,
                    Descricao = tip.Descricao,
                    Situacao = tip.Situacao,
                    DataDeInsercao = tip.DataDeInsercao,
                    DataDeAlteracao = tip.DataDeAlteracao,
                    DataDeExclusao = tip.DataDeExclusao
                }).ToList();
        }
    }
}
