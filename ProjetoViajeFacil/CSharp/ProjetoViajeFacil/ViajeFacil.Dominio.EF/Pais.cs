using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace ViajeFacil.Dominio.EF
{
    [Table("pais", Schema = "dbo")]
    public partial class Pais
    {
        [Key]
        [Column(name: "id_pais")]
        public long CodigoPais { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;
    }
}
