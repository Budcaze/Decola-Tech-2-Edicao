using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 2; i <= n; i+=2)
            {
             
                var b = Math.Pow(i, 2);
                Console.WriteLine(i + "^" + "2 = " + b);
            }
            Console.ReadLine();
        }
    }
}
