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
    [Table("Cidade")]
    public partial class Cidade
    {
        [Key]
        [Column(name: "Codigo")]
        public int CodigoCidade { get; set; }

        [Column(name: "Nome")]
        [Unicode(false)]
        public string Nome { get; set; } = null!;

        [Column(name: "CodigoIBGE7")]
        public int CodigoIBGE7 { get; set; }

        [Column(name: "CodigoEstado")]
        public int CodigoEstado { get; set; }
    }
}
