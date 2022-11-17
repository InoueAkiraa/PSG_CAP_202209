using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Tipo_Rebanho", Schema = "dbo")]
    public partial class TipoRebanho
    {
        [Key]
        [Column("ID_Tipo")]
        public int CodigoTipoRebanho { get; set; }

        [Column("Descricao")]
        [Unicode(false)]
        public string Descricao { get; set; } = null!;

        [Column("Situacao")]
        public bool? Situacao { get; set; }

        [Column(name:"DataInclusao", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }

        [Column(name: "DataExclusao", TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }
    }
}
