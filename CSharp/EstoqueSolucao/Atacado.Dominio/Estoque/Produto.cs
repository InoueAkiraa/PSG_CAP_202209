
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.Estoque
{
    public class Produto : BaseEstoque
    {
        private int codigoCategoria;

        private int codigoSubcategoria;

        public int CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }
        public int CodigoSubcategoria { get => this.codigoSubcategoria; set => this.codigoSubcategoria = value; }

        public Produto(int codigoSubcategoria) : base()
        {
            this.codigoSubcategoria = codigoSubcategoria;
        }

        public Produto(int codigo, string descricao, bool ativo, DateTime dataInclusao, int codigoSubcategoria)
            : base(codigo, descricao, ativo, dataInclusao)
        {
            this.codigoSubcategoria = codigoSubcategoria;
        }

        public Produto(int codigo, int codigoSubcategoria, int codigoCategoria, string descricao, DateTime dataInclusao)
            : base(codigo, descricao, true, dataInclusao)
        {
            this.codigoSubcategoria = codigoSubcategoria;
            this.codigoCategoria = codigoCategoria;
        }
    }
}