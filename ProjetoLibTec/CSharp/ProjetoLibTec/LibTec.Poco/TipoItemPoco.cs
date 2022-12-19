namespace LibTec.Poco
{
    public class TipoItemPoco
    {
        public int CodigoTipoItem { get; set; }

        public string Descricao { get; set; } = null!;

        public bool? Situacao { get; set; }

        public DateTime? DataDeInclusao { get; set; }

        public DateTime? DataDeAlteracao { get; set; }

        public DateTime? DataDeExclusao { get; set; }
    }
}
