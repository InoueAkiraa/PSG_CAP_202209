using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ViajeFacil.Dominio.EF
{
    [Table("endereco", Schema = "dbo")]
    public partial class Endereco
    {
        [Key]
        [Column(name: "id_endereco")]
        public long CodigoEndereco { get; set; }

        [Column(name: "rua")]
        [Unicode(false)]
        [StringLength(100)]
        public string Rua { get; set; } = null!;

        [Column(name: "numero")]
        public int Numero { get; set; }

        [Column(name: "complemento")]
        [Unicode(false)]
        [StringLength(255)]
        public string? Complemento { get; set; }

        [Column(name: "bairro")]
        [Unicode(false)]
        [StringLength(100)]
        public string Bairro { get; set; } = null!;

        [Column(name: "cep")]
        [Unicode(false)]
        [StringLength(9)]
        public string CEP { get; set; } = null!;

        [Column(name: "id_cidade")]
        public long CodigoCidade { get; set; }
    }
}
