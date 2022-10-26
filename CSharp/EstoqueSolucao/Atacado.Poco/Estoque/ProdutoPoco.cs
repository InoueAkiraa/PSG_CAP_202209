using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Estoque
{
    public class ProdutoPoco : BaseEstoque
    {
        private int codigoSubcategoria;

        public int CodigoSubcategoria { get => this.codigoSubcategoria; set => this.codigoSubcategoria = value; }
        public ProdutoPoco() : base()
        { }
        public ProdutoPoco(int codigo, string descricao, bool ativo, DateTime dataInclusao, int codigoSubcategoria) : base(codigo, descricao, ativo, dataInclusao)
        {
            this.codigoSubcategoria = codigoSubcategoria;
        }
    }
}
