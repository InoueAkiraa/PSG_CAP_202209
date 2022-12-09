using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco.Viagem
{
    public class RotaPoco
    {
        public long CodigoRota { get; set; }

        public string PontoInicial { get; set; } = null!;

        public string PontoFinal { get; set; } = null!;

        public RotaPoco() 
        { }
    }
}
