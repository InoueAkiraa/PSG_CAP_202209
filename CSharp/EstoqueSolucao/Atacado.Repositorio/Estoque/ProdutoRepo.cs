using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Repositorio.Base;
using Atacado.DB.EF.Database;

namespace Atacado.Repositorio.Estoque
{
    public class ProdutoRepo : BaseRepositorio<Produto>
    {
        private ProjetoAcademiaContext contexto;

        public ProdutoRepo()
        {
            this.contexto = new ProjetoAcademiaContext(); //instanciamos um objeto do tipo EstoqueContexto
        }

        public override Produto Create(Produto instancia) //Caso ele deseje criar uma nova subcategoria
        {
            this.contexto.Produtos.Add(instancia);                                                        //vai chamar o método de EstoqueContexto
            return instancia;
        }

        public override Produto Delete(int chave) //vai deletar baseado no código da subcategoria
        {
            Produto del = this.Read(chave); //Chama o método READ para verificar se a chave (id subcategoria) existe
            if (del == null) //caso não existe
            {
                return null; //não faça nada
            }
            else
            {
                this.contexto.Produtos.Remove(del);
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
            return this.contexto.Produtos.ToList();
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
                atu.CodigoCategoria = instancia.CodigoCategoria;
                atu.CodigoSubcategoria = instancia.CodigoSubcategoria;                
                atu.Descricao = instancia.Descricao;
                return atu;
            }
        }
    }
}
