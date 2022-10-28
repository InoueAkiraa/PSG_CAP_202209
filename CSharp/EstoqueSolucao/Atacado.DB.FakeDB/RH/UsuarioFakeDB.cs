using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.RH;

namespace Atacado.DB.FakeDB.RH
{
    public static class UsuarioFakeDB
    {
        private static List<Usuario> usuarios;

        public static List<Usuario> Usuarios
        {
            get
            {
                if (usuarios == null)
                {
                    usuarios = new List<Usuario>();
                    Carregar();
                }
                return usuarios;
            }
        }

        private static void Carregar()
        {
            usuarios.Add(new Usuario(1, "user1@login.com", "senha123", "Client"));

            usuarios.Add(new Usuario(2, "user2@login.com", "senha321", "Client"));

            usuarios.Add(new Usuario(3, "user3@login.com", "senha987", "Client"));

            usuarios.Add(new Usuario(4, "user4@login.com", "senha789", "Client"));

            usuarios.Add(new Usuario(5, "admin1@login.com", "senha007", "Admin"));
        }

    }
}
