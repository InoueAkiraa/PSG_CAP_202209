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
    public class BilheteService : GenericService<Bilhete, BilhetePoco>
    {
        public BilheteService(ExameCapContexto contexto) : base(contexto) 
        { }

        public override List<BilhetePoco> Consultar(Expression<Func<Bilhete, bool>>? predicate = null)
        {
            IQueryable<Bilhete> query;
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

        public override List<BilhetePoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Bilhete> query;
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

        public override List<BilhetePoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Bilhete, bool>>? predicate = null)
        {
            IQueryable<Bilhete> query;
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

        public override List<BilhetePoco> ConverterPara(IQueryable<Bilhete> query)
        {
            return query.Select(bil =>
                new BilhetePoco()
                {
                    CodigoBilhete = bil.CodigoBilhete,
                    NumeroBilhete = bil.NumeroBilhete,
                    Assento = bil.Assento
                }).ToList();
        }
    }
}
