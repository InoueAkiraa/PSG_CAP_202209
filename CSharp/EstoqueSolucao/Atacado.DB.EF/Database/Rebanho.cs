using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Rebanho", Schema = "dbo")]
    public partial class Rebanho
    {
        [Key]
        [Column(name: "ID_Rebanho")]
        public int CodigoRebanho { get; set; }

        [Column(name: "Ano_Ref")]
        public int AnoRef { get; set; }

        [Column(name: "ID_Municipio")]
        public int CodigoMunicipio { get; set; }

        [Column(name: "ID_Tipo_Rebanho")]
        public int CodigoTipoRebanho { get; set; }

        [Column(name: "Tipo_Rebanho")]
        [Unicode(false)]
        public string DescricaoTipoRebanho { get; set; } = null!;

        [Column(name: "Quantidade")]
        public int? Quantidade { get; set; }

        [Column(name: "Situacao")]
        public bool? Situacao { get; set; }

        [Column(name: "DataInclusao", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }

        [Column(name: "DataExclusao", TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }
    }
}
