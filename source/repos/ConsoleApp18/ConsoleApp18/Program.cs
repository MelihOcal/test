using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett nummer");
            int num1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Skriv in ett annat nummer");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);


            Console.ReadLine();
        }

    }
}
