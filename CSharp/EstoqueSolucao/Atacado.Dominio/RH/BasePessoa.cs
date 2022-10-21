using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.RH
{
    public abstract class BasePessoa
    {
        protected int id;
        protected Endereco endereco;

        public int Id { get => id; set => id = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }

        public BasePessoa()
        {
            this.endereco = new Endereco();
        }

        public BasePessoa(int id) : this()
        {
            this.id = id;
        }
    }
}