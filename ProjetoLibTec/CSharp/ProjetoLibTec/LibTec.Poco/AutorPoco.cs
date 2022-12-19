namespace LibTec.Poco
{
    public class AutorPoco
    {
        public int CodigoAutor { get; set; }

        public string Nome { get; set; } = null!;

        public bool? Situacao { get; set; } 

        public DateTime? DataDeInclusao { get; set; } 

        public DateTime? DataDeAlteracao { get; set; }

        public DateTime? DataDeExclusao { get; set; }
    }
}
