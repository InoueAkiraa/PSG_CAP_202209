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
    [Table("ponto_parada", Schema = "dbo")]
    public partial class PontoParada
    {
        [Key]
        [Column(name: "id_ponto_parada")]
        public long CodigoPontoParada { get; set; }

        [Column(name: "descricao")]
        [Unicode(false)]
        [StringLength(255)]
        public string Descricao { get; set; } = null!;

        [Column(name: "latitude")]
        [Unicode(false)]
        [StringLength(50)]
        public string Latitude { get; set; } = null!;

        [Column(name: "longitude")]
        [Unicode(false)]
        [StringLength(50)]
        public string Longitude { get; set; } = null!;

        [Column(name: "id_rota")]
        public long CodigoRota { get; set; }
    }
}
