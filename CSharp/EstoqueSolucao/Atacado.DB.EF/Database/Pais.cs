using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Pais", Schema = "Geral")]
    public partial class Pais
    {
        [Key]
        [Column("PaisID")]
        public int PaisId { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string Sigla { get; set; } = null!;
        [StringLength(2)]
        [Unicode(false)]
        public string CodigoIdioma { get; set; } = null!;
        [Unicode(false)]
        public string Descricao { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? DataInsert { get; set; }
    }
}
