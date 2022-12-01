
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clinica.Poco.Odonto;
using Clinica.Servico.Base;
using Clinica.Dominio.EF;
using System.Linq.Expressions;

namespace Clinica.Servico.Odonto
{
    public class ProcedimentosServico : GenericService<Clinica.Dominio.EF.Servico, ServicoPoco>
    {
        public ProcedimentosServico(ClinicaContext contexto) : base(contexto)
        { }

        public override List<ServicoPoco> Consultar(Expression<Func<Clinica.Dominio.EF.Servico, bool>>? predicate = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;
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

        public override List<ServicoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;
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

        public override List<ServicoPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Dominio.EF.Servico, bool>>? predicate = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;
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

        public override List<ServicoPoco> ConverterPara(IQueryable<Clinica.Dominio.EF.Servico> query)
        {
            return query.Select(pro =>
               new ServicoPoco()
               {
                   CodigoServico = pro.CodigoServico,
                   DataAlteracao = pro.DataAlteracao,
                   DataInclusao = pro.DataInclusao,
                   Descricao = pro.Descricao,
                   MedidaPreventiva = pro.MedidaPreventiva,
                   Preco = pro.Preco,
                   Situacao = pro.Situacao,
                   TipoExame = pro.TipoExame,
                   TipoServico = pro.TipoServico,
                   DenteTratado = pro.DenteTratado,
                   MaterialUsado = pro.MaterialUsado,
                   DenteExtraido = pro.DenteExtraido,
                   DenteCanalPar = pro.DenteCanalPar,
                   CodigoTipoServico = pro.CodigoTipoServico
               }).ToList();
        }
    }
}
