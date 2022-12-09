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
    public class RotaService : GenericService<Rota, RotaPoco>
    {
        public RotaService(ViajeFacilContexto contexto) : base(contexto) 
        { }

        public override List<RotaPoco> Consultar(Expression<Func<Rota, bool>>? predicate = null)
        {
            IQueryable<Rota> query;
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

        public override List<RotaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Rota> query;
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

        public override List<RotaPoco> ConverterPara(IQueryable<Rota> query)
        {
            return query.Select(rot =>
                new RotaPoco()
            {
                CodigoRota = rot.CodigoRota,
                PontoInicial = rot.PontoInicial,
                PontoFinal = rot.PontoFinal
            }).ToList();
        }
    }
}
