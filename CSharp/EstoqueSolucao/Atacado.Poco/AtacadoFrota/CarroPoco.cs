using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.AtacadoFrota
{
    public class CarroPoco : BasePesoCargaPoco
    {
        private int numPassageiros;

        public int NumPassageiros { get => numPassageiros; set => numPassageiros = value; }

        public CarroPoco() : base()
        { }
    }
}
