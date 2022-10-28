using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.RH;

namespace Atacado.DB.FakeDB.RH
{
    public static class PrestadorFakeDB
    {
        private static List<Prestador> prestadores; 

        public static List<Prestador> Prestadores
        {
            get
            {
                if (prestadores == null)
                {
                    prestadores = new List<Prestador>();
                    Carregar();
                }
                return prestadores;
            }
        }

        private static void Carregar()
        {
            prestadores.Add(new Prestador(1, "123", "321", new DateTime(1986, 4, 10), "Luizao Engenheiro de Software",
                "Colossus Sistemas", "Colossus@empresa.com", new DateOnly(2000, 1, 1), new DateOnly(2010, 1, 1)));

            prestadores.Add(new Prestador(2, "456", "654", new DateTime(1968, 10, 4), "Fósseis Escavamentos",
                "F.E - Escavamentos e Terraplanagem LTDA ", "F.E@empresa.com", new DateOnly(1990, 2, 2), new DateOnly(2000, 2, 2)));

            prestadores.Add(new Prestador(3, "789", "987", new DateTime(1990, 6, 6), "Estrela da Borracha",
                "Borracharia - Estrela da Borracha", "EstrelaDaBorracha@empresa.com", new DateOnly(2005, 3, 3), new DateOnly(2015, 3, 3)));

            prestadores.Add(new Prestador(4, "111", "222", new DateTime(1663, 2, 3), "Correios",
                "Empresa Brasileira de Correios e Telégrafos", "Correios@empresa.com", new DateOnly(1970, 10, 10), new DateOnly(2022, 5, 5)));

            prestadores.Add(new Prestador(5, "282", "183", new DateTime(2003, 9, 10), "Kabum!",
                "KaBuM! Comércio Eletrônico S/A", "Kabum@empresa.com", new DateOnly(2001, 11, 11), new DateOnly(2023, 11, 11)));
        }
    }
}
