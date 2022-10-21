using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.RH
{
    public class ParceiroPoco : BaseJuridica
    {
        private double desempenho;
        private double comissao;
        private string setor;

        public double Desempenho { get => desempenho; set => desempenho = value; }
        public double Comissao { get => comissao; set => comissao = value; }
        public string Setor { get => setor; set => setor = value; }

        public ParceiroPoco() : base()
        { }
    }
}
