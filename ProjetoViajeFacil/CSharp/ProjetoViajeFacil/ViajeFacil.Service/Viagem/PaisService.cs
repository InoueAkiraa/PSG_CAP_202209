using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco.Viagem;
using ViajeFacil.Service.Base;

namespace ViajeFacil.Service.Viagem
{
    public class PaisService : GenericService<Pais, PaisPoco>
    {
        public PaisService(ViajeFacilContexto contexto) : base(contexto) 
        { }

        public override List<PaisPoco> Consultar(Expression<Func<Pais, bool>>? predicate = null)
        {
            IQueryable<Pais> query;
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

        public override List<PaisPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Pais> query;
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

        public override List<PaisPoco> ConverterPara(IQueryable<Pais> query)
        {
            return query.Select(pai =>
                new PaisPoco()
            {
                CodigoPais = pai.CodigoPais,
                Nome = pai.Nome
            }).ToList();
        }
    }
}
