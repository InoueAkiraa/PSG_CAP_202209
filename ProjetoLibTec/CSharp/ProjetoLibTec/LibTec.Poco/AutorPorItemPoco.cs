namespace LibTec.Poco
{
    public class AutorPorItemPoco
    {
        public int CodigoAutorPorItem { get; set; }

        public int CodigoAutor { get; set; }

        public int CodigoItem { get; set; }

        public bool? Situacao { get; set; }

        public DateTime? DataDeInclusao { get; set; }

        public DateTime? DataDeAlteracao { get; set; }

        public DateTime? DataDeExclusao { get; set; }
    }
}
