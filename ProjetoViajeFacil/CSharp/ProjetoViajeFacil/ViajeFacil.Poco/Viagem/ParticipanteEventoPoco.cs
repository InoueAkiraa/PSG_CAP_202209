using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco.Viagem
{
    public class ParticipanteEventoPoco
    {
        public long CodigoParticipante { get; set; }

        public int Pagamento { get; set; }

        public string Sugestao { get; set; } = null!;

        public int? Avaliacao { get; set; }

        public long CodigoEvento { get; set; }

        public long CodigoUsuario { get; set; }

        public ParticipanteEventoPoco() 
        { }
    }
}
