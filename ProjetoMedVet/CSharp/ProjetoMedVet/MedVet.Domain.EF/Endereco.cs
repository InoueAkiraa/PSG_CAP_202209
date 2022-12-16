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
    [Table("Endereco")]
    public partial class Endereco
    {
        [Key]
        [Column(name: "Codigo")]
        public int CodigoEndereco { get; set; }

        [Column(name: "Rua")]
        [Unicode(false)]
        [StringLength(100)]
        public string Rua { get; set; } = null!;

        [Column(name: "Numero")]
        public int Numero { get; set; }

        [Column(name: "Complemento")]
        [Unicode(false)]
        [StringLength(255)]
        public string? Complemento { get; set; }

        [Column(name: "Bairro")]
        [Unicode(false)]
        [StringLength(100)]
        public string Bairro { get; set; } = null!;

        [Column(name: "CEP")]
        [Unicode(false)]
        [StringLength(9)]
        public string CEP { get; set; } = null!;

        [Column(name: "CodigoCidade")]
        public int CodigoCidade { get; set; }
    }
}
