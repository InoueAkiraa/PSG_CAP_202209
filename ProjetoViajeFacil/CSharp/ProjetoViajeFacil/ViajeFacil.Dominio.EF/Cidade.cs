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
    [Table("cidade",Schema = "dbo")]
    public partial class Cidade
    {
        [Key]
        [Column(name: "id_cidade")]
        public long CodigoCidade { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "codigo_IBGE7")]
        public long CodigoIBGE7 { get; set; }

        [Column(name: "uf")]
        [Unicode(false)]
        [StringLength(2)]
        public string SiglaUF { get; set; } = null!;

        [Column(name: "id_estado")]
        public long CodigoEstado { get; set; }
    }
}
