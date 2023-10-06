using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            
          
            Console.WriteLine("Var vänligen skriv ditt namn och efternamn");

            string namn = Console.ReadLine();
            string efternamn = Console.ReadLine();
            
            Console.WriteLine(" hej "  +  namn  +  efternamn + " välkommen hur gammal är du?");

            int ålder = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("du heter " + namn + "och är " + ålder + " gammal");

           
                Console.ReadLine();
        }
    }
}
