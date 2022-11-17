using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Pecuaria
{
    public class RebanhoPoco
    {
        public int CodigoRebanho { get; set; }

        public int AnoRef { get; set; }

        public int CodigoMunicipio { get; set; }

        public int CodigoTipoRebanho { get; set; }

        public string DescricaoTipoRebanho { get; set; } = null!;

        public int? Quantidade { get; set; }

        public bool? Situacao { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public DateTime? DataExclusao { get; set; }

        public RebanhoPoco() 
        { }
    }
}
