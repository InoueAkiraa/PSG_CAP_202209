using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco.Viagem;
using ViajeFacil.Service.Base;

namespace ViajeFacil.Service.Viagem
{
    public class InstituicaoService : GenericService<Instituicao, InstituicaoPoco>
    {
        public InstituicaoService(ViajeFacilContexto contexto) : base(contexto) 
        { }

        public override List<InstituicaoPoco> Consultar(Expression<Func<Instituicao, bool>>? predicate = null)
        {
            IQueryable<Instituicao> query;
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

        public override List<InstituicaoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Instituicao> query;
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

        public override List<InstituicaoPoco> ConverterPara(IQueryable<Instituicao> query)
        {
            return query.Select(ins =>
                new InstituicaoPoco()
            {
                CodigoInstituicao = ins.CodigoInstituicao,
                Nome = ins.Nome,
                Telefone = ins.Telefone,
                CodigoEndereco = ins.CodigoEndereco
            }).ToList();
        }
    }
}
