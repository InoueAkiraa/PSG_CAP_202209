using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco.Viagem
{
    public class CidadePoco
    {
        public long CodigoCidade { get; set; }

        public string Nome { get; set; } = null!;

        public long CodigoIBGE7 { get; set; }

        public string SiglaUF { get; set; } = null!;

        public long CodigoEstado { get; set; }

        public CidadePoco() 
        { }
    }
}
