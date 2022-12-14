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
    public class PassageiroService : GenericService<Passageiro, PessoaPoco>
    {
        public PassageiroService(ExameCapContexto contexto) : base(contexto) 
        { }

        public override List<PessoaPoco> Consultar(Expression<Func<Passageiro, bool>>? predicate = null)
        {
            IQueryable<Passageiro> query;
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
            IQueryable<Passageiro> query;
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

        public override List<PessoaPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Passageiro, bool>>? predicate = null)
        {
            IQueryable<Passageiro> query;
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

        public override List<PessoaPoco> ConverterPara(IQueryable<Passageiro> query)
        {
            return query.Select(pas =>
                new PessoaPoco()
            {
                CodigoPassageiro = pas.CodigoPassageiro,
                Nome = pas.Nome,
                Email = pas.Email,
                Telefone = pas.Telefone,
                Usuario = pas.Usuario,
                Senha = pas.Senha,
                Documento = pas.Documento,
                NumeroCartao = pas.NumeroCartao,
                DataNascimento = pas.DataNascimento
            }).ToList();
        }
    }
}
