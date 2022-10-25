using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.RH
{
    public class UsuarioPoco
    {
        private int codigo;
        private string login;
        private string senha;
        private string permissao;
        
        public int Codigo { get => codigo; set => codigo = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Permissao { get => permissao; set => permissao = value; }

        public UsuarioPoco() : base()
        { }
    }
}
