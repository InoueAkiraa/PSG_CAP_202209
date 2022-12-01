using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Poco.Odonto
{
    public class TipoServicoPoco
    {
        public int CodigoTipoServico { get; set; }

        public string SiglaTipoServico { get; set; } = null!;

        public string DescricaoTipoServico { get; set; } = null!;

        public TipoServicoPoco() : base() 
        { }
    }
}
