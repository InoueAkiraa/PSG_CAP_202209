using System;

namespace Atacado.Poco.Estoque
{
    public class ProdutoPoco
    {        
        public int Codigo { get; set; }        

        public int CodigoCategoria { get; set; }

        public int CodigoSubcategoria { get; set; }

        public string Descricao { get; set; } = null!;

        public DateTime DataInsert { get; set; }

        public bool? Ativo { get; set; }

        public ProdutoPoco()
        { }
    }
}
