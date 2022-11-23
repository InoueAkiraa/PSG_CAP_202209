using Clinica.Servico.Base;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clinica.Dominio.EF;
using Clinica.Poco.Odonto;
using System.Linq.Expressions;

namespace Clinica.Servico.Odonto
{
    public class ProfissaoServico : GenericService<Profissao, ProfissaoPoco>
    {
        public ProfissaoServico(ClinicaContext contexto) : base(contexto)
        { }

        public override List<ProfissaoPoco> Consultar(Expression<Func<Profissao, bool>>? predicate = null)
        {
            IQueryable<Profissao> query;
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

        public override List<ProfissaoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Profissao> query;
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

        public override List<ProfissaoPoco> ConverterPara(IQueryable<Profissao> query)
        {
            return query.Select(pro =>
                new ProfissaoPoco()
                {
                    CodigoProfissao = pro.CodigoProfissao,
                    Descricao = pro.Descricao,
                    DataInclusao = pro.DataInclusao,
                    Situacao = pro.Situacao
                }).ToList();
        }
    }
}
