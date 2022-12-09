using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ViajeFacil.Dominio.EF
{
    [Table("estado",Schema = "dbo")]
    public partial class Estado
    {
        [Key]
        [Column(name: "id_estado")]
        public long CodigoEstado { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "codigo_uf")]
        public long? CodigoUF { get; set; }

        [Column(name: "uf")]
        [Unicode(false)]
        [StringLength(2)]
        public string SiglaUF { get; set; } = null!;

        [Column(name: "id_regiao")]
        public long CodigoRegiao { get; set; }

    }
}
