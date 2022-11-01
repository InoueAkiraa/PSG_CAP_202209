using Atacado.Repositorio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.DB.EF.Database;

namespace Atacado.Repositorio.Estoque
{
    public class SubcategoriaRepo : BaseRepositorio<Subcategoria>
    {
        private ProjetoAcademiaContext contexto;

        public SubcategoriaRepo()
        {
            this.contexto = new ProjetoAcademiaContext(); //instanciamos um objeto do tipo EstoqueContexto
        }

        public override Subcategoria Create(Subcategoria instancia) //Caso ele deseje criar uma nova subcategoria
        {
            this.contexto.Subcategorias.Add(instancia);             //vai chamar o método de EstoqueContexto
            this.contexto.SaveChanges();
            return instancia;
        }

        public override Subcategoria Delete(int chave) //vai deletar baseado no código da subcategoria
        {
            Subcategoria del = this.Read(chave); //Chama o método READ para verificar se a chave (id subcategoria) existe
            if (del == null) //caso não existe
            {
                return null; //não faça nada
            }
            else
            {
                this.contexto.Subcategorias.Remove(del);
                this.contexto.SaveChanges();
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
            return this.contexto.Subcategorias.ToList();
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
                atu.CodigoCategoria = instancia.CodigoCategoria;
                atu.Descricao = instancia.Descricao;
                atu.Ativo = instancia.Ativo;
                this.contexto.SaveChanges();
                return atu;
            }
        }
    }
}
