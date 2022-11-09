using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Servico.Base;
using Atacado.DB.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Repositorio.Estoque;
using Atacado.Repositorio.Base;
using System.Linq.Expressions;

namespace Atacado.Servico.Estoque
{
    public class CategoriaServico : BaseServico<CategoriaPoco, Categoria>
    {
        private GenericRepository<Categoria> genrepo;
        public CategoriaServico() 
        {
            this.genrepo = new GenericRepository<Categoria>();
        }
        public override CategoriaPoco Add(CategoriaPoco poco)
        {
            Categoria nova = this.ConvertTo(poco);
            //Categoria criada = this.repo.Create(nova);
            Categoria criada = this.genrepo.Insert(nova);
            CategoriaPoco criadaPoco = this.ConvertTo(criada);
            return criadaPoco;
        }

        public override List<CategoriaPoco> Browse()
        {
            return this.Browse(null);
        }

        public override List<CategoriaPoco> Browse(Expression<Func<Categoria, bool>> predicate = null)
        {
            List<CategoriaPoco> listaPoco;
            IQueryable<Categoria> query;
            if (predicate == null)
            {
                //query = this.repo.Read(null);
                query = this.genrepo.Browseable(null);
            }
            else
            {
                //query = this.repo.Read(predicate);
                query = this.genrepo.Browseable(predicate);
            }

            listaPoco = query.Select(cat =>
                    new CategoriaPoco()
                    {
                        Codigo = cat.Codigo,
                        Descricao = cat.Descricao,
                        Ativo = cat.Ativo,
                        DataInsert = cat.DataInsert
                    }
                )
                .ToList();
            return listaPoco;
        }

        public override CategoriaPoco ConvertTo(Categoria dominio)
        {
            return new CategoriaPoco()
            {
                Codigo = dominio.Codigo, 
                Descricao = dominio.Descricao, 
                Ativo = dominio.Ativo,
                DataInsert = dominio.DataInsert
            };
        }

        public override Categoria ConvertTo(CategoriaPoco poco)
        {
            return new Categoria()
            {
                Codigo = poco.Codigo,
                Descricao = poco.Descricao,
                Ativo = poco.Ativo,
                DataInsert = poco.DataInsert
            };
        }

        public override CategoriaPoco Delete(int chave)
        {
            //Categoria del = this.repo.Delete(chave);
            Categoria del = this.genrepo.Delete(chave);
            CategoriaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override CategoriaPoco Delete(CategoriaPoco poco)
        {
            //Categoria del = this.repo.Delete(poco.Codigo);
            Categoria del = this.genrepo.Delete(poco.Codigo);
            CategoriaPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override CategoriaPoco Edit(CategoriaPoco poco)
        {
            Categoria editada = this.ConvertTo(poco);
            //Categoria alterada = this.repo.Update(editada);
            Categoria alterada = this.genrepo.Update(editada);
            CategoriaPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override CategoriaPoco Read(int chave)
        {
            //Categoria lida = this.repo.Read(chave);
            Categoria lida = this.genrepo.GetById(chave);
            CategoriaPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
