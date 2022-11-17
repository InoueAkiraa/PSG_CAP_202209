using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.DB.EF.Database;
using Atacado.Poco.Pecuaria;
using System.Linq.Expressions;

namespace Atacado.Servico.Pecuaria
{
    public class RebanhoServico : GenericService<Rebanho, RebanhoPoco>
    {
        public override List<RebanhoPoco> Consultar(Expression<Func<Rebanho, bool>>? predicate = null)
        {
            IQueryable<Rebanho> query;
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

        public override List<RebanhoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Rebanho> query;
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

        public override List<RebanhoPoco> ConverterPara(IQueryable<Rebanho> query)
        {
            return query.Select(reb =>
                    new RebanhoPoco
                    {
                        CodigoRebanho = reb.CodigoRebanho,
                        AnoRef = reb.AnoRef,
                        CodigoMunicipio = reb.CodigoMunicipio,
                        CodigoTipoRebanho = reb.CodigoTipoRebanho,
                        DescricaoTipoRebanho = reb.DescricaoTipoRebanho,
                        Quantidade = reb.Quantidade,
                        Situacao = reb.Situacao,
                        DataInclusao = reb.DataInclusao,
                        DataAlteracao = reb.DataAlteracao,
                        DataExclusao = reb.DataExclusao
                    }).ToList();
        }
    }
}
