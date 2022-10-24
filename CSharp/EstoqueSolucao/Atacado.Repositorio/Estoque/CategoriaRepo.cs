using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Repositorio.Base;
using Atacado.Dominio.Estoque;
using Atacado.DB.FakeDB.Estoque;

namespace Atacado.Repositorio.Estoque
{
    public class CategoriaRepo : BaseRepositorio<Categoria>
    {
        private EstoqueContexto contexto;

        public CategoriaRepo()
        {
            this.contexto = new EstoqueContexto();
        }

        public override Categoria Create(Categoria instancia)
        {
            throw new NotImplementedException();
        }

        public override Categoria Delete(int chave)
        {
            throw new NotImplementedException();
        }

        public override Categoria Delete(Categoria instancia)
        {
            throw new NotImplementedException();
        }

        public override Categoria Read(int chave)
        {
            return this.contexto.Categorias.SingleOrDefault(cat => cat.Codigo == chave);
        }

        public override List<Categoria> Read()
        {
            return this.contexto.Categorias;
        }

        public override Categoria Update(Categoria instancia)
        {
            throw new NotImplementedException();
        }
    }
}
