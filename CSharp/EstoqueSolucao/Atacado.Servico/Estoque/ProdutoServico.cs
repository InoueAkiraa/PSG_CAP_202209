using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.DB.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Repositorio.Estoque;
using System.Linq.Expressions;
using Atacado.Repositorio.Base;

namespace Atacado.Servico.Estoque
{
    public class ProdutoServico : GenericService<Produto, ProdutoPoco>
    {                
        public override List<ProdutoPoco> Consultar(Expression<Func<Produto, bool>>? predicate = null)
        {
            IQueryable<Produto> query;
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

        public override List<ProdutoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Produto> query;
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

        public override List<ProdutoPoco> ConverterPara(IQueryable<Produto> query)
        {
            return query.Select(pro =>
                    new ProdutoPoco()
                    {
                        Codigo = pro.Codigo,
                        CodigoCategoria = pro.CodigoCategoria,
                        CodigoSubcategoria = pro.CodigoSubcategoria,
                        Descricao = pro.Descricao,
                        Ativo = pro.Ativo,
                        DataInsert = pro.DataInsert
                    }
                )
                .ToList();
        }
    }
}
