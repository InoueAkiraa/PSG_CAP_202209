using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Model.RH
{
    public class Endereco
    {
        private int id;
        private string logradouro;
        private int numero;
        private string complemento;
        private string bairro;
        private string cep;
        private string cidade;
        private string uf;
        
        public int Id { get => id; set => id = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }

        public Endereco() //CONSTRUTOR VAZIO
        { }

        public Endereco(int id, string logradouro, int numero, string complemento, string bairro, 
            string cep, string cidade, string uf) //CONSTRUTOR COM PARÂMETROS
        {
            this.id = id;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.uf = uf;
        }
    }
}
