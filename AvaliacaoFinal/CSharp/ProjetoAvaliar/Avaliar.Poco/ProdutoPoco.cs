namespace Avaliar.Poco
{
    public class ProdutoPoco
    {
        public int CodigoProduto { get; set; }
        public int CodigoCategoria { get; set; }
        public string Descricao { get; set; } = null!;
        public bool? Ativo { get; set; }
        public DateTime? DataInclusao { get; set; }
    }
}
