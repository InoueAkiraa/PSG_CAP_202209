using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedVet.Poco
{
    public class PessoaPoco
    {
        public int CodigoPessoa { get; set; }

        public int CodigoTipoPessoa { get; set; }

        public char SiglaTipoPessoa { get; set; } 

        public string Nome { get; set; } = null!;

        public int CodigoEndereco { get; set; }

        public string CPF { get; set; } = null!;

        public string Telefone { get; set; } = null!;

        public char Sexo { get; set; } 

        public string? Escolaridade { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string Email { get; set; } = null!;

        public string? Cargo { get; set; }

        public DateTime? DataAdmissao { get; set; }

        public DateTime? DataDemissao { get; set; }

        public bool? Situacao { get; set; }

        public DateTime? DataDeInsercao { get; set; }

        public DateTime? DataDeAlteracao { get; set; }

        public DateTime? DataDeExclusao { get; set; }

    }
}
