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
    [Table("tipo_usuario", Schema = "dbo")]
    public partial class TipoUsuario
    {
        [Key]
        [Column(name: "id_tipo_usuario")]
        public long CodigoTipoUsuario { get; set; }

        [Column(name: "descricao")]
        [Unicode(false)]
        [StringLength(100)]
        public string Descricao { get; set; } = null!;
    }
}
