namespace Avaliar.Poco
{
    public class CategoriaPoco
    {
        public int CodigoCategoria { get; set; }
        public string Descricao { get; set; } = null!;
        public DateTime? DataInclusao { get; set; }
        public bool? Ativo { get; set; }
    }
}
