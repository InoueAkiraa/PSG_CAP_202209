namespace MedVet.Poco
{
    public class TipoAtendimentoPoco
    {
        public int CodigoTipoAtendimento { get; set; }

        public char SiglaTipoAtendimento { get; set; }

        public string Descricao { get; set; } = null!;

        public bool? Situacao { get; set; }

        public DateTime? DataDeInsercao { get; set; }

        public DateTime? DataDeAlteracao { get; set; }

        public DateTime? DataDeExclusao { get; set; }
    }
}
