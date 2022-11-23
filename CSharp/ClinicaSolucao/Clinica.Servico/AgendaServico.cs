using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Clinica.Dominio.EF;
using Clinica.Poco.Odonto;
using Clinica.Servico.Base;

namespace Clinica.Servico
{
    public class AgendaServico : GenericService<Agenda, AgendaPoco>
    {
        public AgendaServico(ClinicaContext contexto) : base(contexto) 
        { }

        public override List<AgendaPoco> Consultar(Expression<Func<Agenda, bool>>? predicate = null)
        {
            IQueryable<Agenda> query;
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

        public override List<AgendaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Agenda> query;
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

        public override List<AgendaPoco> ConverterPara(IQueryable<Agenda> query)
        {
            return query.Select(age =>
                new AgendaPoco()
                {
                    CodigoAgenda = age.CodigoAgenda,
                    CodigoPaciente = age.CodigoPaciente,
                    CodigoConsulta = age.CodigoConsulta,
                    Ano = age.Ano,
                    Situacao = age.Situacao,
                    DataInclusao = age.DataInclusao,
                    DataAlteracao = age.DataAlteracao
                }).ToList();
        }
    }
}
