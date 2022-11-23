using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Dominio.EF
{
    [Table("Profissao", Schema = "dbo")]
    public partial class Profissao
    {
        [Key]
        [Column(name: "CodigoProfissao")]
        public int CodigoProfissao { get; set; }

        [Column(name: "Descricao")]
        [Unicode(false)]
        public string Descricao { get; set; } = null!;

        [Column(name: "DataInsert", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "Ativo")]
        public bool? Situacao { get; set; }
    }
}
