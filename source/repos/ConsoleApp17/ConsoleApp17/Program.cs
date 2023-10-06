using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int summa = 0;

            Console.WriteLine("hur många tal vill du skriva in?");
            Int32.TryParse(Console.ReadLine(), out int antal);


            Console.WriteLine("summan av alla tal blir:" + summa);
            Console.ReadLine();



            List<int> sifferLista = new List<int>(antal);

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("skriv in ett tal!");
                Int32.TryParse(Console.ReadLine(), out int result);
                sifferLista.Add(result);
            }

            foreach (int nummer in sifferLista)
            {
                summa += nummer;
            }

        }
    }






}
    

