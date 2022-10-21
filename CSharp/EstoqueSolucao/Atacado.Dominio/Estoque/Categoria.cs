using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.Estoque
{

    public class Categoria : BaseEstoque
    {
        private List<Subcategoria> subcategorias;
        public List<Subcategoria> Subcategorias { get => this.subcategorias; set => this.subcategorias = value; }

        public Categoria() : base()
        {
            this.subcategorias = new List<Subcategoria>();
        }

        public Categoria(int codigo, string descricao, bool ativo, DateTime dataInclusao)
            : base(codigo, descricao, ativo, dataInclusao)
        {
            this.subcategorias = new List<Subcategoria>();
        }


    }
}
