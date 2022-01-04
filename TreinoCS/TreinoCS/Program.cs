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

            int[] teste = new int[4];
            for (int c = 0; c < teste.Length; c++)
            {
                teste[c] = c + 2;
                Console.WriteLine(teste[c]);
            }
            
            Console.ReadLine();


        }
    }
    
}
