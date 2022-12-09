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
    [Table("participante_evento", Schema = "dbo")]
    public partial class ParticipanteEvento
    {
        [Key]
        [Column(name: "id_participante")]
        public long CodigoParticipante { get; set; }

        [Column(name: "pagamento")]
        public int Pagamento { get; set; }

        [Column(name: "sugestao")]
        [Unicode(false)]
        [StringLength(255)]
        public string Sugestao { get; set; } = null!;

        [Column(name: "avaliacao")]
        public int? Avaliacao { get; set; }

        [Column(name: "id_evento")]
        public long CodigoEvento { get; set; }

        [Column(name: "id_Usuario")]
        public long CodigoUsuario { get; set; }
    }
}
