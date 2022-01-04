using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome: ");
             String x = Console.ReadLine().ToLower();
            if (x == "dudu") {
                Console.WriteLine("Olá, " + x);
                    }
            else
            {
                Console.WriteLine("Seu nome é feio");
            }
           Console.ReadLine();
   
        }
    }
}
