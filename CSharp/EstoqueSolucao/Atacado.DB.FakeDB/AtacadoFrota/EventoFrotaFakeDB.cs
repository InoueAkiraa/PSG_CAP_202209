using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.AtacadoFrota;

namespace Atacado.DB.FakeDB.AtacadoFrota
{
    public static class EventoFrotaFakeDB
    {
        private static List<EventoFrota> eventos;

        public static List<EventoFrota> Eventos
        {
            get
            {
                if (eventos == null)
                {
                    eventos = new List<EventoFrota>();
                    Carregar();
                }
                return eventos;
            }
        }

        private static void Carregar()
        {
            eventos.Add(new EventoFrota(true, 1, DateTime.Now, "Renato Akira", new DateOnly(2022, 10, 17),
                new DateOnly(2022,10,23), 50, 100, "Lançamento de um novo produto"));

            eventos.Add(new EventoFrota(true, 2, DateTime.Now, "Marlon Victor", new DateOnly(2022, 10, 3),
                new DateOnly(2022, 10, 9), 20, 80, "Comemoração em prol da parceria com empresa vizinha"));

            eventos.Add(new EventoFrota(true, 3, DateTime.Now, "Rafael Gemelli", new DateOnly(2022, 10, 10),
                new DateOnly(2022, 10, 16), 30, 70, "Início da campanha beneficente"));

            eventos.Add(new EventoFrota(true, 4, DateTime.Now, "Bruno Barreto", new DateOnly(2022, 10, 24),
                new DateOnly(2022, 10, 30), 10, 60, "Início do evento de vendas"));

            eventos.Add(new EventoFrota(true, 5, DateTime.Now, "Tiago Exemplo", new DateOnly(2022, 10, 31),
                new DateOnly(2022, 11, 6), 0, 50, "Início do evento de demonstração de carros antigos"));
        }
    }
}
