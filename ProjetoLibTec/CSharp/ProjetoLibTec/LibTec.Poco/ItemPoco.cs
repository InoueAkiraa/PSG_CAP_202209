namespace LibTec.Poco
{
    public class ItemPoco
    {
        public int CodigoItem { get; set; }

        public string Descricao { get; set; } = null!;

        public string ISBN { get; set; } = null!;

        public string Observacoes { get; set; } = null!;

        public int CodigoTipoItem { get; set; }

        public bool? Situacao { get; set; }

        public DateTime? DataDeInclusao { get; set; }

        public DateTime? DataDeAlteracao { get; set; }

        public DateTime? DataDeExclusao { get; set; }
    }
}
