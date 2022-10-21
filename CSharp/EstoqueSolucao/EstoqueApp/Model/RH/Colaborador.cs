using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Model.RH
{
    public class Colaborador : BaseFisica
    {
        private string ctps;
        private string pis;
        private string tituloEleitor;
        private bool reservista;
        private string estadoCivil;
        private int numDependentes;
        private bool ativo;
        private string setor;
        private string cargo;
        private double salario;
        private string telefone1;
        private string telefone2;

        public string Ctps { get => ctps; set => ctps = value; }
        public string Pis { get => pis; set => pis = value; }
        public string TituloEleitor { get => tituloEleitor; set => tituloEleitor = value; }
        public bool Reservista { get => reservista; set => reservista = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public int NumDependentes { get => numDependentes; set => numDependentes = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Setor { get => setor; set => setor = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Telefone1 { get => telefone1; set => telefone1 = value; }
        public string Telefone2 { get => telefone2; set => telefone2 = value; }

        public Colaborador() : base()
        {
        }

        public Colaborador(int id, string nome, string cpf, string rg, string genero, DateTime nasc, 
            string emailPessoal, string ctps, string pis, string tituloEleitor, bool reservista, 
            string estadoCivil, int numDependentes, bool ativo, string setor, string cargo,
            double salario, string telefone1, string telefone2)
            : base(id, nome, cpf, rg, genero, nasc, emailPessoal)
        {
            this.ctps = ctps;
            this.pis = pis;
            this.tituloEleitor = tituloEleitor;
            this.reservista = reservista;
            this.estadoCivil = estadoCivil;
            this.numDependentes = numDependentes;
            this.ativo = ativo;
            this.setor = setor;
            this.cargo = cargo;
            this.salario = salario;
            this.telefone1 = telefone1;
            this.telefone2 = telefone2;
        }
        
        public void Admitir()
        { }

        public void Demitir()
        { }
    }
}
