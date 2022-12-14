using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExameCap.Poco
{
    public class PessoaPoco
    {
        public int CodigoFuncionario { get; set; }

        public int CodigoPassageiro { get; set; }

        public string Nome { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Telefone { get; set; } = null!;

        public string Usuario { get; set; } = null!;

        public string Senha { get; set; } = null!;

        public string Matricula { get; set; } = null!;

        public string ContaCorrente { get; set; } = null!;

        public string Documento { get; set; } = null!;

        public string NumeroCartao { get; set; } = null!;

       // public string TipoPessoa { get; set; } = null!;

        public DateTime DataNascimento { get; set; }

        public PessoaPoco() 
        { }
    }
}
