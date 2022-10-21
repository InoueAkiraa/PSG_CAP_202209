using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.Estoque
{
    public class Subcategoria : BaseEstoque
    {
        private int codigoCategoria;
        private List<Produto> produtos;
        public int CodigoCategoria { get => this.codigoCategoria; set => this.codigoCategoria = value; }
        public List<Produto> Produtos { get => this.produtos; set => this.produtos = value; }

        public Subcategoria() : base()
        {
            this.produtos = new List<Produto>();
        }

        public Subcategoria(int codigo, string descricao, bool ativo, DateTime dataInclusao, int codigoCategoria)
            : base(codigo, descricao, ativo, dataInclusao)
        {
            this.codigoCategoria = codigoCategoria;
            this.produtos = new List<Produto>();
        }
    }
}
