using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {




            bool minbool = true;
            string namn = "";
            while (minbool)
            {
                Console.WriteLine("Välj menyval"
                    + "\n1 - Ange ditt namn:"
                    + "\n2 - Skriv ut ditt namn:"
                    + "\n3 - avsluta");
                int input = 0;

                try
                {
                     input = Convert.ToInt32(Console.ReadLine());
                }
                
                catch
                {
                    Console.WriteLine("Fel kod vänligen följ vad som står");
                }
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Vad heter du?");
                        namn = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(" Hej " + namn + " välkommen");
                        break;
                    case 3:
                        minbool = false;
                        Console.WriteLine("Hej då!");
                        break;
                    default:
                        Console.WriteLine("Nu gick något fel");
                        break;
                }
            }
        }

    }
}
