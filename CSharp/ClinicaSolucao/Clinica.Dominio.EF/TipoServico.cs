using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Dominio.EF
{
    [Table("TipoServico", Schema = "dbo")]
    public partial class TipoServico
    {
        [Key]
        [Column(name: "CodigoTipoServico")]
        public int CodigoTipoServico { get; set; }

        [Column(name: "SiglaTipoServico")]
        [Unicode(false)]
        [StringLength(2)]
        public string SiglaTipoServico { get; set; } = null!;

        [Column(name: "DescricaoTipoServico")]
        [Unicode(false)]
        [StringLength(50)]
        public string DescricaoTipoServico { get; set; } = null!;
    }
}
