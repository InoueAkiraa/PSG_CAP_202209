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
    public class TipoStatusReservaServico : ServicoGenerico<TipoStatusReserva, TipoStatusReservaPoco>
    {
        public TipoStatusReservaServico(LibTecContext contexto) : base(contexto) 
        { }

        public override List<TipoStatusReservaPoco> Consultar(Expression<Func<TipoStatusReserva, bool>>? predicate = null)
        {
            IQueryable<TipoStatusReserva> query;
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

        public override List<TipoStatusReservaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<TipoStatusReserva> query;
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

        public override List<TipoStatusReservaPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<TipoStatusReserva, bool>>? predicate = null)
        {
            IQueryable<TipoStatusReserva> query;
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

        public override List<TipoStatusReservaPoco> ConverterPara(IQueryable<TipoStatusReserva> query)
        {
            return query.Select(tsr =>
                new TipoStatusReservaPoco()
            {
                CodigoTipoStatusReserva = tsr.CodigoTipoStatusReserva,
                Descricao = tsr.Descricao,
                Situacao = tsr.Situacao,
                DataDeInclusao = tsr.DataDeInclusao,
                DataDeAlteracao = tsr.DataDeAlteracao,
                DataDeExclusao = tsr.DataDeExclusao
            }).ToList();
        }
    }
}
