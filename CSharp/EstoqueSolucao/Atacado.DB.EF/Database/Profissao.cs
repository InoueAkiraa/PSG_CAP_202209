using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Profissao", Schema = "RH")]
    public partial class Profissao
    {
        [Key]
        [Column("ProfissaoID")]
        public int ProfissaoId { get; set; }
        [Unicode(false)]
        public string Descricao { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? DataInsert { get; set; }
        [Column(name: "Ativo")]
        public bool? Ativo { get; set; }
    }
}
