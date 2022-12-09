using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco.Viagem
{
    public class EventoPoco
    {
        public long CodigoEvento { get; set; }

        public string Titulo { get; set; } = null!;

        public string Descricao { get; set; } = null!;

        public DateTime DataIda { get; set; }

        public DateTime DataVolta { get; set; }

        public long CodigoInstituicao { get; set; }

        public long CodigoEndereco { get; set; }

        public long CodigoRotaIda { get; set; }

        public long CodigoRotaVolta { get; set; }

        public long CodigoUsuarioResponsavel { get; set; }

        public EventoPoco() 
        { }
    }
}
