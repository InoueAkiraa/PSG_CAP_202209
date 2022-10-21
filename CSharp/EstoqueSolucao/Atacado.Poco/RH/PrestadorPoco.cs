using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.RH
{
    public class PrestadorPoco : BaseJuridica
    {
        private DateOnly dataContratoInicial;
        private DateOnly dataContratoFinal;

        public DateOnly DataContratoInicial { get => dataContratoInicial; set => dataContratoInicial = value; }
        public DateOnly DataContratoFinal { get => dataContratoFinal; set => dataContratoFinal = value; }

        public PrestadorPoco() : base()
        { }        
    }
}
