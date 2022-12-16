using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MedVet.Domain.EF
{
    [Table ("Estado")]
    public partial class Estado
    {
        [Key]
        [Column(name: "Codigo")]
        public int CodigoEstado { get; set; }

        [Column(name: "Nome")]
        [Unicode(false)]
        public string Nome { get; set; } = null!;

        [Column(name: "UF")]
        [Unicode(false)]
        [StringLength(2)]
        public string SiglaUF { get; set; } = null!;
    }
}
