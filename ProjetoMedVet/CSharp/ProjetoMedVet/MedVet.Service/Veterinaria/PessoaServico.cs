using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MedVet.Domain.EF;
using MedVet.Service.Base;
using MedVet.Poco;
using System.Linq.Expressions;

namespace MedVet.Service.Veterinaria
{
    public class PessoaServico : ServicoGenerico<Pessoa, PessoaPoco>
    {
        public PessoaServico(MedVetContext contexto) : base(contexto) 
        { }

        public override List<PessoaPoco> Consultar(Expression<Func<Pessoa, bool>>? predicate = null)
        {
            IQueryable<Pessoa> query;
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

        public override List<PessoaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Pessoa> query;
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

        public override List<PessoaPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Pessoa, bool>>? predicate = null)
        {
            IQueryable<Pessoa> query;
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

        public override List<PessoaPoco> ConverterPara(IQueryable<Pessoa> query)
        {
            return query.Select(pes =>
                new PessoaPoco()
            {
                CodigoPessoa = pes.CodigoPessoa,
                CodigoTipoPessoa = pes.CodigoTipoPessoa,
                SiglaTipoPessoa = pes.SiglaTipoPessoa,
                Nome = pes.Nome,
                CodigoEndereco = pes.CodigoEndereco,
                CPF = pes.CPF,
                Telefone = pes.Telefone,
                Sexo = pes.Sexo,
                Escolaridade = pes.Escolaridade,
                DataNascimento = pes.DataNascimento,
                Email = pes.Email,
                Cargo = pes.Cargo,
                DataAdmissao = pes.DataAdmissao,
                DataDemissao = pes.DataDemissao,
                Situacao = pes.Situacao,
                DataDeInsercao = pes.DataDeInsercao,
                DataDeAlteracao = pes.DataDeAlteracao,
                DataDeExclusao = pes.DataDeExclusao
            }).ToList();
        }
    }
}
