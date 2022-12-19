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
    [Table ("Autor", Schema = "dbo")]
    public partial class Autor
    {
        [Key]
        [Column(name: "Codigo")]
        public int CodigoAutor { get; set; }

        [Column(name: "Nome")]
        [Unicode(false)]
        public string Nome { get; set; } = null!;

        [Column(name: "Ativo")]
        public bool? Situacao { get; set; } //DEFAULT

        [Column(name: "DataInclusao", TypeName = "datetime")]
        public DateTime? DataDeInclusao { get; set; } //DEFAULT

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataDeAlteracao { get; set; }

        [Column(name: "DataExclusao", TypeName = "datetime")]
        public DateTime? DataDeExclusao { get; set; }
    }
}
