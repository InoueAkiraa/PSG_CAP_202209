using Atacado.Dominio.Estoque;
using Atacado.Repositorio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.DB.FakeDB.Estoque;

namespace Atacado.Repositorio.Estoque
{
    public class SubcategoriaRepo : BaseRepositorio<Subcategoria>
    {
        private EstoqueContexto contexto;

        public SubcategoriaRepo()
        {
            this.contexto = new EstoqueContexto(); //instanciamos um objeto do tipo EstoqueContexto
        }

        public override Subcategoria Create(Subcategoria instancia) //Caso ele deseje criar uma nova subcategoria
        {                                                           //vai chamar o método de EstoqueContexto
            return this.contexto.AddSubcategoria(instancia);
        }

        public override Subcategoria Delete(int chave) //vai deletar baseado no código da subcategoria
        {
            Subcategoria del = this.Read(chave); //Chama o método READ para verificar se a chave (id subcategoria) existe
            if (this.contexto.Subcategorias.Remove(del) == false) //caso não existe
            {
                return null; //não faça nada
            }
            else
            {
                return del; //caso exista, retorna o registro apagado
            }
        }

        public override Subcategoria Delete(Subcategoria instancia)
        {
            return this.Delete(instancia.Codigo); 
        }

        public override Subcategoria Read(int chave)
        {
            return this.contexto.Subcategorias.SingleOrDefault(cat => cat.Codigo == chave);
        }

        public override List<Subcategoria> Read()
        {
            return this.contexto.Subcategorias;
        }

        public override Subcategoria Update(Subcategoria instancia)
        {
            Subcategoria atu = this.Read(instancia.Codigo);
            if (atu == null)
            {
                return null;
            }
            else
            {
                atu.Descricao = instancia.Descricao;
                atu.Ativo = instancia.Ativo;
                return atu;
            }
        }
    }
}
