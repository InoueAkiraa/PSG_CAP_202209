using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Repositorio.Base;
using Atacado.DB.EF.Database;
using System.Linq.Expressions;

namespace Atacado.Repositorio.Estoque
{
    public class CategoriaRepo : BaseRepositorio<Categoria>
    {
        private ProjetoAcademiaContext contexto;

        public CategoriaRepo()
        {
            this.contexto = new ProjetoAcademiaContext();
        }

        public override Categoria Create(Categoria instancia)
        {
            this.contexto.Categorias.Add(instancia);
            this.contexto.SaveChanges();
            return instancia;
        }

        public override Categoria Delete(int chave)
        {
            Categoria del = this.Read(chave);
            if (del == null)
            {
                return null;
            }
            else
            {
                this.contexto.Categorias.Remove(del);
                this.contexto.SaveChanges();
                return del;
            }
        }

        public override Categoria Delete(Categoria instancia)
        {
            return this.Delete(instancia.Codigo);
        }

        public override Categoria Read(int chave)
        {
            return this.contexto.Categorias.SingleOrDefault(cat => cat.Codigo == chave);
        }

        public override List<Categoria> Read()
        {
            return this.contexto.Categorias.ToList();
        }

        public override IQueryable<Categoria> Read(Expression<Func<Categoria, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return this.contexto.Categorias.AsQueryable();
            }
            else
            {
                return this.contexto.Categorias.Where(predicate).AsQueryable();
            }
        }



        public override Categoria Update(Categoria instancia)
        {
            Categoria atu = this.Read(instancia.Codigo);
            if (atu == null)
            {
                return null;
            }
            else
            {
                atu.Descricao = instancia.Descricao;
                atu.Ativo = instancia.Ativo;
                this.contexto.SaveChanges();
                return atu;
            }
        }
    }
}
