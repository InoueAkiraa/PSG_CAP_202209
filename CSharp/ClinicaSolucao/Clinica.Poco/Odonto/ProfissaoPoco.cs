using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Poco.Odonto
{
    public class ProfissaoPoco
    {
        public int CodigoProfissao { get; set; }

        public string Descricao { get; set; } = null!;

        public DateTime? DataInclusao { get; set; }

        public bool? Situacao { get; set; }

        public ProfissaoPoco() 
        { }
    }
}
