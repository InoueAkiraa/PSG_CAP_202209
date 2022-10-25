using Atacado.Dominio.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DB.FakeDB.Estoque
{
    public class EstoqueContexto
    {
        public List<Categoria> Categorias
        {
            get => CategoriaFakeDB.Categorias;
        }

        public List<Subcategoria> Subcategorias
        {
            get => SubcategoriaFakeDB.Subcategorias;
        }

        public List<Produto> Produtos
        {
            get => ProdutoFakeDB.Produtos;
        }

        public EstoqueContexto()
        {
        }

        public Categoria AddCategoria(Categoria instancia)
        {
            int novaChave = this.Categorias.Count + 1;
            instancia.Codigo = novaChave;
            this.Categorias.Add(instancia);
            return instancia;
        }

        public Subcategoria AddSubcategoria(Subcategoria instancia)
        {
            int novaChave = this.Subcategorias.Count + 1;
            instancia.Codigo = novaChave;
            this.Subcategorias.Add(instancia);
            return instancia;
        }

        public Produto AddProduto(Produto instancia)
        {
            int novaChave = this.Produtos.Count + 1;
            instancia.Codigo = novaChave;
            this.Produtos.Add(instancia);
            return instancia;
        }
    }
}