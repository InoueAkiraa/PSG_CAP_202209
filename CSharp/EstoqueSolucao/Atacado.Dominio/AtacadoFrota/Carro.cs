using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.AtacadoFrota
{
    public class Carro : BasePesoCarga
    {
        private int numPassageiros;

        public int NumPassageiros { get => numPassageiros; set => numPassageiros = value; }

        public Carro() : base()
        { }

        public Carro(bool ativo, int codigo, DateTime dataInclusao, string chassi, string cor, string marca, 
            string modelo, string placa, double pesoBruto, double pesoLiquido, double pesoTotal, int numPassageiros) 
            : base(ativo, codigo, dataInclusao, chassi, cor, marca, modelo, placa, pesoBruto, pesoLiquido, pesoTotal)
        {
            this.numPassageiros = numPassageiros;
        }
    }
}
