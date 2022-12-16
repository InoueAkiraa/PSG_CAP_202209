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
    public class AtendimentoServico : ServicoGenerico<Atendimento, AtendimentoPoco>
    {
        public AtendimentoServico(MedVetContext contexto) : base(contexto) 
        { }

        public override List<AtendimentoPoco> Consultar(Expression<Func<Atendimento, bool>>? predicate = null)
        {
            IQueryable<Atendimento> query;
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

        public override List<AtendimentoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Atendimento> query;
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

        public override List<AtendimentoPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Atendimento, bool>>? predicate = null)
        {
            IQueryable<Atendimento> query;
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

        public override List<AtendimentoPoco> ConverterPara(IQueryable<Atendimento> query)
        {
            return query.Select(ate =>
                new AtendimentoPoco()
            {
                CodigoAtendimento = ate.CodigoAtendimento,
                CodigoTipoAtendimento = ate.CodigoTipoAtendimento,
                SiglaTipoAtendimento = ate.SiglaTipoAtendimento,
                CodigoAtendente = ate.CodigoAtendente,
                CodigoPaciente = ate.CodigoPaciente,
                CodigoMedico = ate.CodigoMedico,
                CodigoEnfermeiro = ate.CodigoEnfermeiro,
                CodigoConvenio = ate.CodigoConvenio,
                Descricao = ate.Descricao,
                DataHora = ate.DataHora,
                Situacao = ate.Situacao,
                DataDeInsercao = ate.DataDeInsercao,
                DataDeAlteracao = ate.DataDeAlteracao,
                DataDeExclusao = ate.DataDeExclusao
            }).ToList();
        }
    }
}
