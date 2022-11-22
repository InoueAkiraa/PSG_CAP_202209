using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Base;

namespace Clinica.Servico
{
    public class PacienteServico : GenericService<Paciente, PacientePoco>
    {
        public PacienteServico(ClinicaContext context) : base(context) 
        { }

        public override List<PacientePoco> Consultar(Expression<Func<Paciente, bool>>? predicate = null)
        {
            IQueryable<Paciente> query;
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

        public override List<PacientePoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Paciente> query;
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

        public override List<PacientePoco> ConverterPara(IQueryable<Paciente> query)
        {
            return query.Select(pac =>
                new PacientePoco()
                {
                    Nome = pac.Nome,
                    Endereco = pac.Endereco,
                    Telefone = pac.Endereco,
                    DataDeNascimento = pac.DataDeNascimento,
                    CodigoProfissao = pac.CodigoProfissao,
                    RG = pac.RG,
                    CPF = pac.CPF,
                    Situacao = pac.Situacao,
                    DataAlteracao = pac.DataAlteracao                    
                }).ToList();
        }
    }
}
