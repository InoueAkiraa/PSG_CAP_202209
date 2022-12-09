using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco.Viagem
{
    public class TipoUsuarioPoco
    {
        public long CodigoTipoUsuario { get; set; }

        public string Descricao { get; set; } = null!;

        public TipoUsuarioPoco() 
        { }
    }
}
