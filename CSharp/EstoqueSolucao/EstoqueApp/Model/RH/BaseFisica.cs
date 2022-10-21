using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Model.RH
{
    public abstract class BaseFisica : BasePessoa
    {
        protected string nome;
        protected string cpf;
        protected string rg;
        protected string genero;
        protected DateTime nasc;
        protected string emailPessoal;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime Nasc { get => nasc; set => nasc = value; }
        public string EmailPessoal { get => emailPessoal; set => emailPessoal = value; }

        public BaseFisica() : base()
        {
        }

        public BaseFisica(int id, string nome, string cpf, string rg, string genero, DateTime nasc, string emailPessoal) 
            : base(id)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.genero = genero;
            this.nasc = nasc;
            this.emailPessoal = emailPessoal;
        }
    }
}
