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
    public class EnderecoService : GenericService<Endereco, EnderecoPoco>
    {
        public EnderecoService(ViajeFacilContexto contexto) : base(contexto) 
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
