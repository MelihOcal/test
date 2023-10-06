using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sifferlista = new List<int>();

            int summa = Console.ReadLine().Length;

            Console.WriteLine("hur många tal vill du skriva in?");
            Int32.TryParse(Console.ReadLine(), out int antal);

               
           
            
            Console.WriteLine("skriv in ett tal!");
            Int32.TryParse(Console.ReadLine(), out int result);
            sifferlista.Add(result);


            Console.WriteLine("summan av alla tal blir:" + summa);
            Console.ReadLine();

            for (int i = 0; i < antal; i++)
            {

            }

        }

    }
}
