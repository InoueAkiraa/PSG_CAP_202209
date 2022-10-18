using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 016 – o mesmo professor quer sortear um dos seus alunos para apagar o quadro. Faça um
    /// programa que ajude ele, lendo o nome deles e escrevendo o nome do escolhido.
    /// </summary>
    public static class Desafio018
    {
        private static List<string> nomes = new List<string>();
        public static void Executar()
        {
            bool sair = false; //SETA FALSE PARA A VARIÁVEL SAIR
            while (sair == false) //ELA ATÉ ENTÃO ESTÁ PRESA NUM LOOP
            {
                Console.WriteLine("Nomes na lista: {0}.", nomes.Count); //MOSTRA A QUANTIDADE DE ALUNOS REGISTRADOS
                bool testar = true; // SETA TRUE PARA A VARIÁVEL
                while (testar == true) //FICA PRESA NUM LOOP "INFINITO"
                {
                    Console.Write("Digite um nome de aluno: ");
                    string nome = Console.ReadLine();

                    if (string.IsNullOrEmpty(nome.Trim())) //NÃO DEIXA O NOME SER VAZIO OU POSSUI ESPAÇOS VAZIOS
                    {
                        Console.WriteLine("Favor não deixe de informar o nome!");
                    }
                    else //SE FOR INFORMADO UM NOME "NORMAL", ELE ADICIONA À LISTA
                    {
                        nomes.Add(nome); //ADICIONANDO NOME À LISTA
                        testar = false; // MUDA A VARIÁVEL PARA FALSE, ENCERRANDO SEU LOOP
                    }

                }
                Console.WriteLine("Deseja sair <S/N>");
                string teste = Console.ReadLine();
                if (teste.ToUpper() == "S")
                {
                    sair = true; // CASO ELE AFIRME QUE DESEJA SAIR, MUDARÁ A VARIÁVEL PARA TRUE, ENCERRANDO NOVAMENTE OUTRO LOOP
                }
                else
                {
                    Console.Clear(); //CASO ELE NÃO QUEIRA SAIR, VAI LIMPA O CONSOLE 
                }                    //E ENTRAR NO LOOP NOVAMENTE, ONDE AS VARIAVEIS BOOLEAN
                                     //ESTARÃO COM VALORES INICIALMENTE TESTADOS
            }
            //ORDENAÇÃO
            nomes.Sort();

            Console.Clear();
            Console.WriteLine("Imprimindo nomes na lista."); //mostra todos os nomes da lista
            foreach (string nome in nomes)
            {
                Console.WriteLine("Aluno {0}", nome);
            }

            Console.WriteLine();

            //SORTEIO
            Random numAleatorio = new Random();

            List<int> pos = new List<int>();
            int indice = 0;
            while (indice < nomes.Count)
            {
                int posicao = numAleatorio.Next(nomes.Count);
                if (pos.Count == 0)
                {
                    pos.Add(posicao);
                    indice++;
                }
                else
                {
                    if (pos.Contains(posicao) == false)
                    {
                        pos.Add(posicao);
                        indice++;
                    }
                }
            }

            //IMPRIME LISTA SORTEADA
            Console.WriteLine("Lista Sorteada");
            for (int i = 0; i < pos.Count; i++)
            {
                int num = pos[i];
                Console.WriteLine("Aluno {0}", nomes[pos[i]]);
                //Console.WriteLine(nomes[pos[i]]);
            }

            //ESCOLHENDO ALGUÉM DA LISTA SORTEADA
            Console.WriteLine();
            int sorteado = numAleatorio.Next(pos.Count);
            Console.WriteLine("Sorteado: {0}", nomes[sorteado]);

        }
    }
}
