using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Estoque
{
    public class SubcategoriaPoco : BaseEstoque
    {
        private int codigoCategoria;

        public int CodigoCategoria { get => this.codigoCategoria; set => this.codigoCategoria = value; }

        public SubcategoriaPoco() : base()
        { }
    }
}
