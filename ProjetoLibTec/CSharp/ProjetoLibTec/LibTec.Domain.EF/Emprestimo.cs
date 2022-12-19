using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibTec.Domain.EF
{
    [Table("Emprestimo", Schema = "dbo")]
    public partial class Emprestimo
    {
        [Key]
        [Column(name: "Codigo")]
        public int CodigoEmprestimo { get; set; }   

        [Column(name: "CodigoUsuario")]
        public int CodigoUsuario { get; set; }

        [Column(name: "CodigoItem")]
        public int CodigoItem { get; set; }

        [Column(name: "QtdRenovado")]
        public int? QuantidadeRenovada { get; set; }

        [Column(name: "DataSaida", TypeName = "datetime")]
        public DateTime DataDeSaida { get; set; }

        [Column(name: "DataExpiracao", TypeName = "datetime")]
        public DateTime DataDeExpiracao { get; set; }

        [Column(name: "DataRetorno", TypeName = "datetime")]
        public DateTime? DataDeRetorno { get; set; }

        [Column(name: "CodigoStatus")]
        public int CodigoStatus { get; set; }

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
