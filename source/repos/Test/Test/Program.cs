using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("skriv ditt namn :");
            string name = Console.ReadLine();

            Console.WriteLine("Hej! " + name);

            Console.WriteLine(" Hur gammal är du? ");
            string age = Console.ReadLine();
            Console.WriteLine(" Du heter " + name + " och är " + age + " gammal!");








            Console.ReadLine();
        }
    }
}
