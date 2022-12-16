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
    [Table ("Atendimento", Schema = "dbo")]
    public partial class Atendimento
    {
        [Key]
        [Column(name: "Codigo")]
        public int CodigoAtendimento { get; set; }

        [Column(name: "CodigoTipoAtendimento")]
        public int CodigoTipoAtendimento { get; set; }

        [Column(name: "SiglaTipoAtendimento")]
        [Unicode(false)]
        [StringLength(1)]
        public char SiglaTipoAtendimento { get; set; }

        [Column(name: "CodigoAtendente")]
        public int? CodigoAtendente { get; set; }

        [Column(name: "CodigoPaciente")]
        public int? CodigoPaciente { get; set; }

        [Column(name: "CodigoMedico")]
        public int? CodigoMedico { get; set; }

        [Column(name: "CodigoEnfermeiro")]
        public int? CodigoEnfermeiro { get; set; }

        [Column(name: "CodigoConvenio")]
        public int CodigoConvenio { get; set; }

        [Column(name: "Descricao")]
        [Unicode(false)]
        public string Descricao { get; set; } = null!;

        [Column(name: "DataHora", TypeName = "datetime")]
        public DateTime DataHora { get; set; }

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
