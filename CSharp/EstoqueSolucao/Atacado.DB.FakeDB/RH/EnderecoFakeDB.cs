using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.RH;

namespace Atacado.DB.FakeDB.RH
{
    public static class EnderecoFakeDB
    {
        private static List<Endereco> enderecos;

        public static List<Endereco> Enderecos
        {
            get
            {
                if (enderecos == null)
                {
                    enderecos = new List<Endereco>();
                    Carregar();
                }
                return enderecos;
            }
        }

        public static void Carregar()
        {
            enderecos.Add(new Endereco(1, "Rua Igarapé", 162, "Casa", "Centro", "30120060", "Belo Horizonte", "MG"));
                                           
            enderecos.Add(new Endereco(2, "Rua Guararapes", 280, "Apartamento", "Boa Viagem", "30130005", "Belo Horizonte", "MG"));
                                           
            enderecos.Add(new Endereco(3, "Rua Almirante Maximiano Fonseca", 320, "Casa", "Zona Portuária", "96204040", "Rio Grande", "RS"));

            enderecos.Add(new Endereco(4, "Rua da Imprensa", 480, "Casa", "Monte Castelo", "79002290", "Campo Grande", "MS"));

            enderecos.Add(new Endereco(5, "Rua Arlindo Nogueira", 11, "Casa", "Centro", "64000290", "Teresina", "PI"));
        }
    }
}
