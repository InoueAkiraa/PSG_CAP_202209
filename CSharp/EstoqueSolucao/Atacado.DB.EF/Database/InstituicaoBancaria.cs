using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("InstituicaoBancaria", Schema = "Geral")]
    public partial class InstituicaoBancaria
    {
        [Key]
        [Column("InstituicaoBancariaID")]
        public int InstituicaoBancariaId { get; set; }
        public int? CodigoBanco { get; set; }
        [Unicode(false)]
        public string Descricao { get; set; } = null!;
        [Column("SiteWWW")]
        [Unicode(false)]
        public string SiteWww { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? DataInsert { get; set; }
    }
}
