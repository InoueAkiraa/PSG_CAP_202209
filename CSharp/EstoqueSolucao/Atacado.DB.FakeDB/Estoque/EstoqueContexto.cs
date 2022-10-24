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

    }
}