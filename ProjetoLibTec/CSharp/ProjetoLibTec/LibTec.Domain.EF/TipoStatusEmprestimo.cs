using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LibTec.Domain.EF
{
    [Table ("TipoStatusEmprestimo", Schema = "dbo")]
    public partial class TipoStatusEmprestimo
    {
        [Key]
        [Column(name: "Codigo")]
        public int CodigoTipoStatusEmprestimo { get; set; }

        [Column(name: "Descricao")]
        [Unicode(false)]
        [StringLength(100)]
        public string Descricao { get; set; } = null!;

        [Column(name: "Ativo")]
        public bool? Situacao { get; set; }

        [Column(name: "DataInclusao", TypeName = "datetime")]
        public DateTime? DataDeInclusao { get; set; }

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataDeAlteracao { get; set; }

        [Column(name: "DataExclusao", TypeName = "datetime")]
        public DateTime? DataDeExclusao { get; set; }
    }
}
