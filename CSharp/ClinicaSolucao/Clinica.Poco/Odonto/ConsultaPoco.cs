using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Poco.Odonto
{
    public class ConsultaPoco
    {
        public int CodigoConsulta { get; set; }

        public string Historico { get; set; } = null!;

        public DateTime Data { get; set; }

        public DateTime Hora { get; set; }

        public DateTime DataHora { get; set; }

        public bool? Situacao { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public ConsultaPoco() 
        { }
    }
}
