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
    public class ProdutoRepo : BaseRepositorio<Produto>
    {
        private EstoqueContexto contexto;

        public ProdutoRepo()
        {
            this.contexto = new EstoqueContexto(); //instanciamos um objeto do tipo EstoqueContexto
        }

        public override Produto Create(Produto instancia) //Caso ele deseje criar uma nova subcategoria
        {                                                           //vai chamar o método de EstoqueContexto
            return this.contexto.AddProduto(instancia);
        }

        public override Produto Delete(int chave) //vai deletar baseado no código da subcategoria
        {
            Produto del = this.Read(chave); //Chama o método READ para verificar se a chave (id subcategoria) existe
            if (this.contexto.Produtos.Remove(del) == false) //caso não existe
            {
                return null; //não faça nada
            }
            else
            {
                return del; //caso exista, retorna o registro apagado
            }
        }

        public override Produto Delete(Produto instancia)
        {
            return this.Delete(instancia.Codigo); //vai deletar a subcategoria se baseando no código da categoria e subcategoria
        }

        public override Produto Read(int chave) //vai realizar a consulta da subcategoria baseada na chave
        {
            return this.contexto.Produtos.SingleOrDefault(cat => cat.Codigo == chave);
        }

        public override List<Produto> Read()
        {
            return this.contexto.Produtos;
        }

        public override Produto Update(Produto instancia)
        {
            Produto atu = this.Read(instancia.Codigo);
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
