namespace Clinica.Poco.Odonto
{
    public class ServicoPoco
    {
        public int CodigoServico { get; set; }

        public string Descricao { get; set; } = null!;

        public double Preco { get; set; }                

        public string TipoServico { get; set; } = null!;

        public bool? Situacao { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public string? MedidaPreventiva { get; set; }

        public string? TipoExame { get; set; }

        public string? MaterialUsado { get; set; }

        public int? DenteTratado { get; set; }

        public int? DenteExtraido { get; set; }

        public int? DenteCanalPar { get; set; }

        public int? CodigoTipoServico { get; set; }

        public ServicoPoco() : base() 
        { }
    }
}
