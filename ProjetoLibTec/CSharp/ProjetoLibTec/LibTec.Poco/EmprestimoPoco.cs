namespace LibTec.Poco
{
    public class EmprestimoPoco
    {
        public int CodigoEmprestimo { get; set; }

        public int CodigoUsuario { get; set; }

        public int CodigoItem { get; set; }

        public int? QuantidadeRenovada { get; set; }

        public DateTime DataDeSaida { get; set; }

        public DateTime DataDeExpiracao { get; set; }

        public DateTime? DataDeRetorno { get; set; }

        public int CodigoStatus { get; set; }

        public bool? Situacao { get; set; }

        public DateTime? DataDeInclusao { get; set; }

        public DateTime? DataDeAlteracao { get; set; }

        public DateTime? DataDeExclusao { get; set; }
    }
}
