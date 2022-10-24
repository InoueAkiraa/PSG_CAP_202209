using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atacado.Dominio.Estoque;

namespace Atacado.DB.FakeDB.Estoque
{
    public static class SubcategoriaFakeDB
    {
        private static List<Subcategoria> subcategorias;

        public static List<Subcategoria> Subcategorias
        {
            get
            {
                if (subcategorias == null)
                {
                    subcategorias = new List<Subcategoria>();
                    Carregar();
                }
                return subcategorias;
            }
        }

        private static void Carregar()
        {
            subcategorias.Add(new Subcategoria(1, "Papinha", true, DateTime.Now, 1));
            subcategorias.Add(new Subcategoria(2, "Sopinha", true, DateTime.Now, 1));
            subcategorias.Add(new Subcategoria(3, "Proteína", true, DateTime.Now, 2));
            subcategorias.Add(new Subcategoria(4, "Carboidratos", true, DateTime.Now, 2));
            subcategorias.Add(new Subcategoria(5, "Vitaminas", true, DateTime.Now, 2));
            subcategorias.Add(new Subcategoria(6, "Hipercalóricos", true, DateTime.Now, 2));
            subcategorias.Add(new Subcategoria(7, "Óxido Nítrico", true, DateTime.Now, 2));
            subcategorias.Add(new Subcategoria(8, "Aminoácidos", true, DateTime.Now, 2));
            subcategorias.Add(new Subcategoria(9, "Propriedade Funcional", true, DateTime.Now, 2));
            subcategorias.Add(new Subcategoria(10, "Achocolatados", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(11, "Bebidas a Base de Soja", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(12, "Bebidas Alcoólicas", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(13, "Café e Cia", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(14, "Chás", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(15, "Isotônicos e Energéticos", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(16, "Refrescos em Pó", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(17, "Refrigerantes", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(18, "Sucos Concentrados", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(19, "Sucos de Frutas Prontos", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(20, "Sucos Naturais", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(21, "Sucos Orgânicos", true, DateTime.Now, 3));
            subcategorias.Add(new Subcategoria(22, "Biscoitos e Bolachas", true, DateTime.Now, 4));
            subcategorias.Add(new Subcategoria(23, "Bolos Caseiros", true, DateTime.Now, 4));
            subcategorias.Add(new Subcategoria(24, "Bolos Prontos", true, DateTime.Now, 4));
            subcategorias.Add(new Subcategoria(25, "Misturas para Bolos", true, DateTime.Now, 4));
            subcategorias.Add(new Subcategoria(26, "Aves (Frango, Peru, etc)", true, DateTime.Now, 5));
            subcategorias.Add(new Subcategoria(27, "Boi", true, DateTime.Now, 5));
            subcategorias.Add(new Subcategoria(28, "Frutos do Mar", true, DateTime.Now, 5));
            subcategorias.Add(new Subcategoria(29, "Hamburguers", true, DateTime.Now, 5));
            subcategorias.Add(new Subcategoria(30, "Outras Carnes", true, DateTime.Now, 5));
            subcategorias.Add(new Subcategoria(31, "Peixes", true, DateTime.Now, 5));
            subcategorias.Add(new Subcategoria(32, "Porco", true, DateTime.Now, 5));
            subcategorias.Add(new Subcategoria(33, "Vitela", true, DateTime.Now, 5));
            subcategorias.Add(new Subcategoria(34, "Empanados", true, DateTime.Now, 6));
            subcategorias.Add(new Subcategoria(35, "Hamburguers", true, DateTime.Now, 6));
            subcategorias.Add(new Subcategoria(36, "Legumes & Cia Congelados", true, DateTime.Now, 6));
            subcategorias.Add(new Subcategoria(37, "Pizzas Congeladas", true, DateTime.Now, 6));
            subcategorias.Add(new Subcategoria(38, "Polpas de Frutas Congeladas", true, DateTime.Now, 6));
            subcategorias.Add(new Subcategoria(39, "Pratos Prontos Congelados", true, DateTime.Now, 6));
            subcategorias.Add(new Subcategoria(40, "Salgados Congelados", true, DateTime.Now, 6));
            subcategorias.Add(new Subcategoria(41, "Conservas em Geral", true, DateTime.Now, 7));
            subcategorias.Add(new Subcategoria(42, "Adoçantes", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(43, "Balas", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(44, "Chicletes", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(45, "Chocolates", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(46, "Doces de Frutas", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(47, "Doces Diversos", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(48, "Gelatinas", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(49, "Geléias", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(50, "Ingredientes Doces", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(51, "Mel e Xaropes", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(52, "Sobremesas em Pó", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(53, "Sobremesas Lácteas", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(54, "Sorvetes", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(55, "Tortas", true, DateTime.Now, 8));
            subcategorias.Add(new Subcategoria(56, "Cereal Matinal", true, DateTime.Now, 9));
            subcategorias.Add(new Subcategoria(57, "Farinhas e Cereais Diversos", true, DateTime.Now, 9));
            subcategorias.Add(new Subcategoria(58, "Mingau e Cia", true, DateTime.Now, 9));
            subcategorias.Add(new Subcategoria(59, "Amendoim e Etc", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(60, "Batata Frita", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(61, "Bobs", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(62, "Casa da Empada", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(63, "Habibs", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(64, "Mc Donalds", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(65, "Pastas & Patês", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(66, "Petiscos Diversos", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(67, "Pipoca", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(68, "Pizzas Congeladas", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(69, "Rei do Mate", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(70, "Salgadinhos & Snacks", true, DateTime.Now, 10));
            subcategorias.Add(new Subcategoria(71, "Frios e Embutidos em Geral", true, DateTime.Now, 11));
            subcategorias.Add(new Subcategoria(72, "Doces de Frutas", true, DateTime.Now, 12));
            subcategorias.Add(new Subcategoria(73, "Frutas Diversas", true, DateTime.Now, 12));
            subcategorias.Add(new Subcategoria(74, "Frutas Secas e em Calda", true, DateTime.Now, 12));
            subcategorias.Add(new Subcategoria(75, "Polpas de Frutas Congeladas", true, DateTime.Now, 12));
            subcategorias.Add(new Subcategoria(76, "Sucos Concentrados", true, DateTime.Now, 12));
            subcategorias.Add(new Subcategoria(77, "Sucos de Frutas Prontos", true, DateTime.Now, 12));
            subcategorias.Add(new Subcategoria(78, "Sucos Naturais", true, DateTime.Now, 12));
            subcategorias.Add(new Subcategoria(79, "Sucos Orgânicos", true, DateTime.Now, 12));
            subcategorias.Add(new Subcategoria(80, "Legumes & Cia Congelados", true, DateTime.Now, 13));
            subcategorias.Add(new Subcategoria(81, "Legumes e Cia Naturais", true, DateTime.Now, 13));
            subcategorias.Add(new Subcategoria(82, "Massas em Geral", true, DateTime.Now, 14));
            subcategorias.Add(new Subcategoria(83, "Caldos", true, DateTime.Now, 15));
            subcategorias.Add(new Subcategoria(84, "Catchup & Mostarda", true, DateTime.Now, 15));
            subcategorias.Add(new Subcategoria(85, "Maionese", true, DateTime.Now, 15));
            subcategorias.Add(new Subcategoria(86, "Molhos", true, DateTime.Now, 15));
            subcategorias.Add(new Subcategoria(87, "Outros Condimentos", true, DateTime.Now, 15));
            subcategorias.Add(new Subcategoria(88, "Iogurtes", true, DateTime.Now, 16));
            subcategorias.Add(new Subcategoria(89, "Leite", true, DateTime.Now, 16));
            subcategorias.Add(new Subcategoria(90, "Milkshakes", true, DateTime.Now, 16));
            subcategorias.Add(new Subcategoria(91, "Ovos", true, DateTime.Now, 16));
            subcategorias.Add(new Subcategoria(92, "Queijos", true, DateTime.Now, 16));
            subcategorias.Add(new Subcategoria(93, "Sobremesas Lácteas", true, DateTime.Now, 16));
            subcategorias.Add(new Subcategoria(94, "Pães em Geral", true, DateTime.Now, 17));
            subcategorias.Add(new Subcategoria(95, "Sopas em Geral", true, DateTime.Now, 18));
            subcategorias.Add(new Subcategoria(96, "Diversos sem Categoria", true, DateTime.Now, 19));
        }
    }
}