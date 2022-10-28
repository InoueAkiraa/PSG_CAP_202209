using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.AtacadoFrota
{
    public abstract class BaseVeiculoPoco : BaseCamposPoco
    {
        protected string chassi;
        protected string cor;
        protected string marca;
        protected string modelo;
        protected string placa;

        public string Chassi { get => chassi; set => chassi = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }

        public BaseVeiculoPoco() : base()
        { }
    }
}
