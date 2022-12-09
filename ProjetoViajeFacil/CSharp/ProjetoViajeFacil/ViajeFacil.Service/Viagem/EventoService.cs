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
    public class EventoService : GenericService<Evento, EventoPoco>
    {
        public EventoService(ViajeFacilContexto contexto) : base(contexto) 
        { }

        public override List<EventoPoco> Consultar(Expression<Func<Evento, bool>>? predicate = null)
        {
            IQueryable<Evento> query;
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

        public override List<EventoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Evento> query;
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

        public override List<EventoPoco> ConverterPara(IQueryable<Evento> query)
        {
            return query.Select(eve =>
                new EventoPoco()
            {
                CodigoEvento = eve.CodigoEvento,
                Titulo = eve.Titulo,
                Descricao = eve.Descricao,
                DataIda = eve.DataIda,
                DataVolta = eve.DataVolta,
                CodigoInstituicao = eve.CodigoInstituicao,
                CodigoEndereco = eve.CodigoEndereco,
                CodigoRotaIda = eve.CodigoRotaIda,
                CodigoRotaVolta = eve.CodigoRotaVolta,
                CodigoUsuarioResponsavel = eve.CodigoUsuarioResponsavel
            }).ToList();
        }
    }
}
