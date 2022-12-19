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
    [Table("AutorPorItem", Schema = "dbo")]
    public partial class AutorPorItem
    {
        [Key]
        [Column(name: "Codigo")]
        public int CodigoAutorPorItem { get; set; }

        [Column(name: "CodigoAutor")]
        public int CodigoAutor { get; set; }

        [Column(name: "CodigoItem")]
        public int CodigoItem { get; set; }

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
