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
    [Table ("TipoPessoa", Schema = "dbo")]
    public partial class TipoPessoa
    {
        [Key]
        [Column(name: "Codigo")]
        public int CodigoTipoPessoa { get; set; }

        [Column(name: "Sigla")]
        [Unicode(false)]
        [StringLength(1)]
        public char SiglaTipoPessoa { get; set; }

        [Column(name: "Descricao")]
        [Unicode(false)]
        public string Descricao { get; set; } = null!;

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
