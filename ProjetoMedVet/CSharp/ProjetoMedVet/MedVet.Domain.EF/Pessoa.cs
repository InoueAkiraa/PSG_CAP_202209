using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MedVet.Domain.EF
{
    [Table ("Pessoa", Schema = "dbo")]
    public partial class Pessoa
    {
        [Key]
        [Column(name: "Codigo")]
        public int CodigoPessoa { get; set; }

        [Column(name: "CodigoTipoPessoa")]
        public int CodigoTipoPessoa { get; set; }

        [Column(name: "SiglaTipoPessoa")]
        [Unicode(false)]
        [StringLength(1)]
        public char SiglaTipoPessoa { get; set; }

        [Column(name: "Nome")]
        [Unicode(false)]
        public string Nome { get; set; } = null!;

        [Column(name: "CodigoEndereco")]
        public int CodigoEndereco { get; set; }

        [Column(name: "CPF")]
        [Unicode(false)]
        [StringLength(14)]
        public string CPF { get; set; } = null!;

        [Column(name: "Telefone")]
        [Unicode(false)]
        [StringLength(14)]
        public string Telefone { get; set; } = null!;

        [Column(name: "Sexo")]
        [Unicode(false)]
        [StringLength(1)]
        public char Sexo { get; set; }

        [Column(name: "Escolaridade")]
        [Unicode(false)]
        public string? Escolaridade { get; set; }

        [Column(name: "DataNascimento", TypeName = "datetime")]
        public DateTime? DataNascimento { get; set; }

        [Column(name: "Email")]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [Column(name: "Cargo")]
        [Unicode(false)]
        public string? Cargo { get; set; }

        [Column(name: "DataAdmissao", TypeName = "datetime")]
        public DateTime? DataAdmissao { get; set; }

        [Column(name: "DataDemissao", TypeName = "datetime")]
        public DateTime? DataDemissao { get; set; }

        [Column(name: "Ativo")]
        public bool? Situacao { get; set; }

        [Column(name: "DataInsert", TypeName = "datetime")]
        public DateTime? DataDeInsercao { get; set; }

        [Column(name: "DataUpdate", TypeName = "datetime")]
        public DateTime? DataDeAlteracao { get; set; }

        [Column(name: "DataDelete", TypeName = "datetime")]
        public DateTime? DataDeExclusao { get; set; }

    }
}
