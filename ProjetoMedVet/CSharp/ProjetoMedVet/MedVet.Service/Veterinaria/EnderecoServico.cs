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
    public class EnderecoServico : ServicoGenerico<Endereco, EnderecoPoco>
    {
        public EnderecoServico(MedVetContext contexto) : base(contexto)
        { }

        public override List<EnderecoPoco> Consultar(Expression<Func<Endereco, bool>>? predicate = null)
        {
            IQueryable<Endereco> query;
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

        public override List<EnderecoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Endereco> query;
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

        public override List<EnderecoPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Endereco, bool>>? predicate = null)
        {
            IQueryable<Endereco> query;
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

        public override List<EnderecoPoco> ConverterPara(IQueryable<Endereco> query)
        {
            return query.Select(end =>
                new EnderecoPoco()
                {
                    CodigoEndereco = end.CodigoEndereco,
                    Rua = end.Rua,
                    Numero = end.Numero,
                    Complemento = end.Complemento,
                    Bairro = end.Bairro,
                    CEP = end.CEP,
                    CodigoCidade = end.CodigoCidade
                }).ToList();
        }
    }
}
