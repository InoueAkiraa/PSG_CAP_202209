﻿using MedVet.Service.Base;
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
    public class EstadoServico : ServicoGenerico<Estado, EstadoPoco>
    {
        public EstadoServico(MedVetContext contexto) : base(contexto)
        { }

        public override List<EstadoPoco> Consultar(Expression<Func<Estado, bool>>? predicate = null)
        {
            IQueryable<Estado> query;
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

        public override List<EstadoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Estado> query;
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

        public override List<EstadoPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Estado, bool>>? predicate = null)
        {
            IQueryable<Estado> query;
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

        public override List<EstadoPoco> ConverterPara(IQueryable<Estado> query)
        {
            return query.Select(est =>
                new EstadoPoco()
                {
                    CodigoEstado = est.CodigoEstado,
                    Nome = est.Nome,
                    SiglaUF = est.SiglaUF
                }).ToList();
        }
    }
}
