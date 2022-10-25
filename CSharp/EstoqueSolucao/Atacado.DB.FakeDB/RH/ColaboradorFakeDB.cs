using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.Dominio.RH;

namespace Atacado.DB.FakeDB.RH
{
    public static class ColaboradorFakeDB
    {
        private static List<Colaborador> colaboradores; //atributo -> lista fortemente tipada Colaborador que se chama
                                                        // colaboradores
        public static List<Colaborador> Colaboradores //propriedade da lista fortemente tipada
        {
            get
            {
                if (colaboradores == null)
                {
                    colaboradores = new List<Colaborador>();
                    Carregar();
                }
                return colaboradores;
            }
        }

        private static void Carregar()
        {
            colaboradores.Add(new Colaborador(1, "Akira", "705", "123", "M", new DateTime(2001, 4, 1), "Akira@hotmail", "253.29399.75-3",
                "120.0227.082-3", "531737812402", true, "Solteiro", 0, true, "Desenvolvimento", "Trainee", 2750.00, "679123",
                "679091"));

            colaboradores.Add(new Colaborador(2, "Marlon", "825", "957", "M", new DateTime(2001, 9, 10), "Marlon@hotmail", "325.15123.75-3",
                "320.18915.082-3", "156165165651", true, "Solteiro", 0, true, "Desenvolvimento", "Trainee", 2750.00, "156521",
                "679111"));

            colaboradores.Add(new Colaborador(3, "Rafael", "258", "852", "M", new DateTime(2001, 4, 1), "Rafael@hotmail", "147.12345.75-3",
                "012.9632.082-3", "165464156165", true, "Divorciado", 0, true, "Desenvolvimento", "Trainee", 2750.00, "679741",
                "679222"));

            colaboradores.Add(new Colaborador(4, "Tiago", "654", "456", "M", new DateTime(2001, 4, 4), "Tiago@hotmail", "145.11101.75-3",
                "001.0007.082-3", "561656561", true, "Casado", 0, true, "Desenvolvimento", "Trainee", 2750.00, "123231",
                "679333"));

            colaboradores.Add(new Colaborador(5, "Bruno", "222", "111", "M", new DateTime(2001, 10, 10), "Bruno@hotmail", "888.98732.75-3",
                "088.0010.082-3", "5665651654", true, "Solteiro", 0, true, "Desenvolvimento", "Trainee", 2750.00, "788989",
                "6791325"));
        }
    }
}
