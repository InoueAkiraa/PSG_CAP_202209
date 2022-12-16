using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedVet.Poco
{
    public class AtendimentoPoco
    {
        public int CodigoAtendimento { get; set; }

        public int CodigoTipoAtendimento { get; set; }

        public char SiglaTipoAtendimento { get; set; }

        public int? CodigoAtendente { get; set; }

        public int? CodigoPaciente { get; set; }

        public int? CodigoMedico { get; set; }

        public int? CodigoEnfermeiro { get; set; }

        public int CodigoConvenio { get; set; }

        public string Descricao { get; set; } = null!;

        public DateTime DataHora { get; set; }

        public bool? Situacao { get; set; }

        public DateTime? DataDeInsercao { get; set; }

        public DateTime? DataDeAlteracao { get; set; }

        public DateTime? DataDeExclusao { get; set; }
    }
}
