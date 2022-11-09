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
    public class SubcategoriaServico : BaseServico<SubcategoriaPoco, Subcategoria>
    {
        private GenericRepository<Subcategoria> genrepo;

        public SubcategoriaServico() 
        {
            this.genrepo = new GenericRepository<Subcategoria>();
        }

        public override SubcategoriaPoco Add(SubcategoriaPoco poco)
        {
            Subcategoria nova = this.ConvertTo(poco);
            Subcategoria criada = this.genrepo.Insert(nova);
            SubcategoriaPoco criadaPoco = this.ConvertTo(criada);
            return criadaPoco;
        }

        public override List<SubcategoriaPoco> Browse()
        {
            return this.Browse(null);
        }

        public override List<SubcategoriaPoco> Browse(Expression<Func<Subcategoria, bool>> predicate = null)
        {
            List<SubcategoriaPoco> listaPoco;
            IQueryable<Subcategoria> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }

            listaPoco = query.Select(sub =>
                    new SubcategoriaPoco()
                    {
                        Codigo = sub.Codigo,
                        CodigoCategoria = sub.CodigoCategoria,
                        Descricao = sub.Descricao,
                        Ativo = sub.Ativo,
                        DataInsert = sub.DataInsert
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override SubcategoriaPoco ConvertTo(Subcategoria dominio)
        {
            return new SubcategoriaPoco()
            {
                Codigo = dominio.Codigo,
                CodigoCategoria = dominio.CodigoCategoria,
                Descricao = dominio.Descricao, 
                Ativo = dominio.Ativo,
                DataInsert = dominio.DataInsert
            };
        }

        public override Subcategoria ConvertTo(SubcategoriaPoco poco)
        {
            return new Subcategoria()
            {
                Codigo = poco.Codigo,
                CodigoCategoria = poco.CodigoCategoria,
                Descricao = poco.Descricao,
                Ativo = poco.Ativo,
                DataInsert = poco.DataInsert
            };
        }

        public override SubcategoriaPoco Delete(int chave)
        {
            Subcategoria del = this.genrepo.Delete(chave);
            SubcategoriaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override SubcategoriaPoco Delete(SubcategoriaPoco poco)
        {
            Subcategoria del = this.genrepo.Delete(poco.Codigo);
            SubcategoriaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override SubcategoriaPoco Edit(SubcategoriaPoco poco)
        {
            Subcategoria editada = this.ConvertTo(poco);
            Subcategoria alterada = this.genrepo.Update(editada);
            SubcategoriaPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override SubcategoriaPoco Read(int chave)
        {
            Subcategoria lida = this.genrepo.GetById(chave);
            SubcategoriaPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
