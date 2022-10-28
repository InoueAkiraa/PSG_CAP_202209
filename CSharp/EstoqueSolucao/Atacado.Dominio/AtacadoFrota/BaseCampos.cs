using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.AtacadoFrota
{
    public abstract class BaseCampos
    {
        protected bool ativo;
        protected int codigo;
        protected DateTime dataInclusao;        

        public bool Ativo { get => ativo; set => ativo = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime DataInclusao { get => dataInclusao; set => dataInclusao = value; }

        public BaseCampos()
        { }

        public BaseCampos(bool ativo, int codigo, DateTime dataInclusao)
        {
            this.ativo = ativo;
            this.codigo = codigo;
            this.dataInclusao = dataInclusao;
        }
    }
}
