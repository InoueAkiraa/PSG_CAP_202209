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
    public class EmprestimoServico : ServicoGenerico<Emprestimo, EmprestimoPoco>
    {
        public EmprestimoServico(LibTecContext contexto) : base(contexto) 
        { }

        public override List<EmprestimoPoco> Consultar(Expression<Func<Emprestimo, bool>>? predicate = null)
        {
            IQueryable<Emprestimo> query;
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

        public override List<EmprestimoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Emprestimo> query;
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

        public override List<EmprestimoPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Emprestimo, bool>>? predicate = null)
        {
            IQueryable<Emprestimo> query;
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

        public override List<EmprestimoPoco> ConverterPara(IQueryable<Emprestimo> query)
        {
            return query.Select(emp =>
                new EmprestimoPoco()
            {
                CodigoEmprestimo = emp.CodigoEmprestimo,
                CodigoUsuario = emp.CodigoUsuario,
                CodigoItem = emp.CodigoItem,
                QuantidadeRenovada = emp.QuantidadeRenovada,
                DataDeSaida = emp.DataDeSaida,
                DataDeExpiracao = emp.DataDeExpiracao,
                DataDeRetorno = emp.DataDeRetorno,
                CodigoStatus = emp.CodigoStatus,
                Situacao = emp.Situacao,
                DataDeInclusao = emp.DataDeInclusao,
                DataDeAlteracao = emp.DataDeAlteracao,
                DataDeExclusao = emp.DataDeExclusao
            }).ToList();
        }
    }
}
