﻿namespace EstudoConsoleApp;

using System;

using EstudoConsoleApp.Aulas;
public class Program
{
    public static void Main(string[] args)
    {
        //ExecutarExemplo001();
        //ExecutarExemplo002();
        //ExecutarExemplo003();
        //ExecutarExemplo004();
        ExecutarExemplo005();
    }

    private static void ExecutarExemplo001()
    {
        Console.WriteLine("Operações Matemáticas");
        Console.WriteLine();

        Console.Write("Informe o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Informe o segundo número:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Somar: {0}", OperacoesMatematicas.Somar(num1, num2));
        Console.WriteLine();
        Console.WriteLine("Subtrair: {0}", OperacoesMatematicas.Subtrair(num1, num2));
        Console.WriteLine();
        Console.WriteLine("Multiplicar: {0}", OperacoesMatematicas.Multiplicar(num1, num2));
        Console.WriteLine();
        Console.WriteLine("Dividir: {0}", OperacoesMatematicas.Dividir(num1, num2));

        Console.ReadLine();
    }

    private static void ExecutarExemplo002()
    {
        Console.WriteLine("Comparações Lógicas");
        Console.WriteLine();

        Console.Write("Informe o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Informe o segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine();
        //Console.WriteLine("{0} é maior que {1} ?", num1, num2);
        ComparacoesLogicas.MaiorQue(num1, num2);
        Console.WriteLine();
        //Console.WriteLine("{0} é menor que {1} ?", num1, num2);
        ComparacoesLogicas.MenorQue(num1, num2);

        Console.ReadLine();
    }

    private static void ExecutarExemplo003()
    {
        Console.WriteLine("Comparações Lógicas");
        Console.WriteLine();

        Console.Write("Informe o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Informe o segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine();
        //Console.WriteLine("{0} é maior que {1} ?", num1, num2);
        ComparacoesLogicasV2.MaiorQue(num1, num2);
        Console.WriteLine();
        //Console.WriteLine("{0} é menor que {1} ?", num1, num2);
        ComparacoesLogicasV2.MenorQue(num1, num2);

        Console.ReadLine();
    }

    private static void ExecutarExemplo004()
    {
        TrabalhandoComDatas.ExibirDataAtual();
        Console.WriteLine();
        TrabalhandoComDatas.ExibirDataAtualFormatada();
        Console.ReadLine();
    }

    private static void ExecutarExemplo005()
    {
        Console.WriteLine("Operações Matemáticas V2");
        Console.WriteLine();

        Console.Write("Informe o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Informe o segundo número:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Somar: {0}", OperacoesMatematicasV2.Somar(num1, num2));
        Console.WriteLine();
        Console.WriteLine("Subtrair: {0}", OperacoesMatematicasV2.Subtrair(num1, num2));
        Console.WriteLine();
        Console.WriteLine("Multiplicar: {0}", OperacoesMatematicasV2.Multiplicar(num1, num2));
        Console.WriteLine();
        Console.WriteLine("Dividir: {0}", OperacoesMatematicasV2.Dividir(num1, num2));
        Console.WriteLine();
        Console.WriteLine("Potenciação (x^y): {0}", OperacoesMatematicasV2.Potenciacao(num1, num2));
        Console.WriteLine();
        Console.WriteLine("Potenciação (y^x): {0}", OperacoesMatematicasV2.Potenciacao(num2, num1));
        Console.WriteLine();
        Console.WriteLine("Radiciação (Raíz Quadrada de N1): {0}", OperacoesMatematicasV2.Radiciacao(num1));
        Console.WriteLine();
        Console.WriteLine("Radiciação (Raíz Quadrada de N2): {0}", OperacoesMatematicasV2.Radiciacao(num2));
        Console.ReadLine();
    }
}