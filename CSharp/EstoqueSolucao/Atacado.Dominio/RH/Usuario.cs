using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.RH
{
    public class Usuario
    {
        private string login;
        private string senha;
        private string permissao;
        private Colaborador colaborador;
        
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Permissao { get => permissao; set => permissao = value; }
        public Colaborador Colaborador { get => colaborador; set => colaborador = value; }

        public Usuario() : base()
        { }

        public Usuario(string login, string senha, string permissao)
        {
            this.login = login;
            this.senha = senha;
            this.permissao = permissao;
        }
    }
}
