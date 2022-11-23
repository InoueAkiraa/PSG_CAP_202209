using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Poco.Odonto
{
    public class AgendaPoco
    {
        public int CodigoAgenda { get; set; }

        public int CodigoPaciente { get; set; }

        public int CodigoConsulta { get; set; }

        public int Ano { get; set; }

        public bool? Situacao { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public AgendaPoco() 
        { }
    }
}
