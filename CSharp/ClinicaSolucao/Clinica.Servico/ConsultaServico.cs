using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clinica.Poco.Odonto;
using Clinica.Dominio.EF;
using Clinica.Servico.Base;
using System.Linq.Expressions;

namespace Clinica.Servico
{
    public class ConsultaServico : GenericService<Consulta, ConsultaPoco>
    {
        public ConsultaServico(ClinicaContext contexto) : base(contexto)
        { }

        public override List<ConsultaPoco> Consultar(Expression<Func<Consulta, bool>>? predicate = null)
        {
            IQueryable<Consulta> query;
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

        public override List<ConsultaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Consulta> query;
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

        public override List<ConsultaPoco> ConverterPara(IQueryable<Consulta> query)
        {
            return query.Select(con =>
                new ConsultaPoco()
                {
                    CodigoConsulta = con.CodigoConsulta,
                    Historico = con.Historico,
                    Data = con.Data,
                    Hora = con.Hora,
                    DataHora = con.DataHora,
                    Situacao = con.Situacao,
                    DataInclusao = con.DataInclusao,
                    DataAlteracao = con.DataAlteracao
                }).ToList();
        }
    }
}
