using ExameCap.Dominio.EF;
using ExameCap.Poco;
using ExameCap.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExameCap.Service.Exame
{
    public class FuncionarioService : GenericService<Funcionario, PessoaPoco>
    {
        public FuncionarioService(ExameCapContexto contexto) : base(contexto)
        { }

        public override List<PessoaPoco> Consultar(Expression<Func<Funcionario, bool>>? predicate = null)
        {
            IQueryable<Funcionario> query;
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
            IQueryable<Funcionario> query;
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

        public override List<PessoaPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Funcionario, bool>>? predicate = null)
        {
            IQueryable<Funcionario> query;
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

        public override List<PessoaPoco> ConverterPara(IQueryable<Funcionario> query)
        {
            return query.Select(fun =>
                new PessoaPoco()
                {
                    CodigoFuncionario = fun.CodigoFuncionario,                    
                    Nome = fun.Nome,
                    Email = fun.Email,
                    Telefone = fun.Telefone,
                    Usuario = fun.Usuario,
                    Senha = fun.Senha,
                    Matricula = fun.Matricula,
                    ContaCorrente = fun.ContaCorrente,                    
                    DataNascimento = fun.DataNascimento
                }).ToList();
        }
    }
}
