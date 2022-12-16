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
    public class ConvenioServico : ServicoGenerico<Convenio, ConvenioPoco>
    {
        public ConvenioServico(MedVetContext contexto) : base(contexto)
        { }

        public override List<ConvenioPoco> Consultar(Expression<Func<Convenio, bool>>? predicate = null)
        {
            IQueryable<Convenio> query;
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

        public override List<ConvenioPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Convenio> query;
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

        public override List<ConvenioPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Convenio, bool>>? predicate = null)
        {
            IQueryable<Convenio> query;
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

        public override List<ConvenioPoco> ConverterPara(IQueryable<Convenio> query)
        {
            return query.Select(con =>
                new ConvenioPoco()
                {
                    CodigoConvenio = con.CodigoConvenio,
                    Descricao = con.Descricao,
                    Plano = con.Plano,
                    Tarifa = con.Tarifa
                }).ToList();
        }
    }
}
