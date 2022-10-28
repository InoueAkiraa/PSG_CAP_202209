using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.AtacadoFrota
{
    public abstract class BaseCamposPoco
    {
        protected bool ativo;
        protected int codigo;
        protected DateTime dataInclusao;        

        public bool Ativo { get => ativo; set => ativo = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime DataInclusao { get => dataInclusao; set => dataInclusao = value; }

        public BaseCamposPoco()
        { }
    }
}
