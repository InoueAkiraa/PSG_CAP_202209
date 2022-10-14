using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Aulas
{
    public static class TrabalhandoComDatas
    {
        public static void ExibirDataAtual()
        {
            Console.WriteLine("Hoje é {0}", DateTime.Now);
            //Console.WriteLine("Hoje é {0}", DateTime.Now.ToString("dd/MM/yyyy"));
        }

        public static void ExibirDataAtualFormatada()
        {
            DateTime data = DateTime.Now;

            // Format Datetime in different formats and display them  
            Console.WriteLine(data.ToString("MM/dd/yyyy"));
            Console.WriteLine(data.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(data.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(data.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(data.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(data.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(data.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(data.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(data.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(data.ToString("MM/dd/yyyy H:mm"));
            Console.WriteLine(data.ToString("MM/dd/yyyy h:mm tt"));
            Console.WriteLine(data.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine(data.ToString("MMMM dd"));
            Console.WriteLine(data.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));
            Console.WriteLine(data.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
            Console.WriteLine(data.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
            Console.WriteLine(data.ToString("HH:mm"));
            Console.WriteLine(data.ToString("hh:mm tt"));
            Console.WriteLine(data.ToString("H:mm"));
            Console.WriteLine(data.ToString("h:mm tt"));
            Console.WriteLine(data.ToString("HH:mm:ss"));
            Console.WriteLine(data.ToString("yyyy MMMM"));
        }
    }
}
