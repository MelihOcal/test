using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("välkommen var vänligen skriv ditt namn!");





            string namn = Console.ReadLine();


           
                Console.WriteLine("hej " + namn + " välkommen! du kommer nu få 3 alternativ att välja på");

            Console.WriteLine("Välj menyval"
                + "\n1 - Ange din favorit mat:"
                + "\n2 - Skriv ut din favorit mat:"
                + "\n3 - avsluta");

            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:

                    Console.WriteLine("varför är det din favorit mat?");
                    break;


                case 2:

                    Console.WriteLine("mmmmm");
                    break;

                case 3:
                   
                    Console.WriteLine("Hej då!");
                    break;
                default:
                    Console.WriteLine("Nu gick något fel");
                   break;
            }
        }
            




           
        
        




        
    }
}
