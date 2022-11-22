using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Dominio.EF
{
    [Table("Paciente", Schema = "dbo")]
    public partial class Paciente
    {
        [Key]
        public int CodigoPaciente { get; set; }

		[Column(name: "Nome")]
		[Unicode(false)]
		public string Nome { get; set; } = null!;
        
		[Column(name: "Endereco")]
        [Unicode(false)]
        public string Endereco { get; set; } = null!;

		[Column(name : "Telefone")]
        [Unicode(false)]
		[StringLength(14)]
        public string Telefone { get; set; } = null!;

		[Column(name : "DataDeNascimento", TypeName = "datetime")]
		public DateTime DataDeNascimento { get; set; }

		[Column(name: "CodigoProfissao")]
		public int CodigoProfissao { get; set; }

        [Column(name: "RG")]
        [Unicode(false)]
        [StringLength(11)]
        public string? RG { get; set; }

        [Column(name: "CPF")]
        [Unicode(false)]
        [StringLength(14)]
        public string? CPF { get; set; }

        [Column(name: "Situacao")]
        public bool? Situacao { get; set; }

        [Column(name: "DataInclusao", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
    }
}
