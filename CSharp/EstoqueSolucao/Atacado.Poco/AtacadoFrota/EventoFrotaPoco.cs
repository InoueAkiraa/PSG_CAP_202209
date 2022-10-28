using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.AtacadoFrota
{
    public class EventoFrotaPoco : BaseCamposPoco
    {
        private string condutor;
        private DateOnly dataInicial;
        private DateOnly dataFinal;
        private double kmInicial;
        private double kmFinal;
        private string motivoEvento;

        public string Condutor { get => condutor; set => condutor = value; }
        public DateOnly DataInicial { get => dataInicial; set => dataInicial = value; }
        public DateOnly DataFinal { get => dataFinal; set => dataFinal = value; }
        public double KmInicial { get => kmInicial; set => kmInicial = value; }
        public double KmFinal { get => kmFinal; set => kmFinal = value; }
        public string MotivoEvento { get => motivoEvento; set => motivoEvento = value; }

        public EventoFrotaPoco() : base()
        { }
    }
}
