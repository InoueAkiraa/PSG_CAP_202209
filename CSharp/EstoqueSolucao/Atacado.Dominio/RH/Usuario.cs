using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.RH
{
    public class Usuario
    {
        private int codigo;
        private string login;
        private string senha;
        private string permissao;
        private Colaborador colaborador;
        
        public int Codigo { get => codigo; set => codigo = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Permissao { get => permissao; set => permissao = value; }
        public Colaborador Colaborador { get => colaborador; set => colaborador = value; }

        public Usuario() : base()
        { }

        public Usuario(int codigo, string login, string senha, string permissao)
        {
            this.codigo = codigo;
            this.login = login;
            this.senha = senha;
            this.permissao = permissao;
            
        }
    }
}
