using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool minbool = true;
            string namn = "";
            while (minbool)


                Console.WriteLine("välj menyval!"
                    + "\n1 - Ange ditt namn:"
                    + "\n2 - Skriv ut ditt namn:"
                    + "\n3 - avsluta");

            minbool = false;

            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)

            {
                case 1:

                    Console.WriteLine("vad heter du?");
                    namn = Console.ReadLine();
                    break;


                case 2:

                    Console.WriteLine("hej " + namn + " välkommen!");
                    break;
            
                case 3:

                    minbool = false;
                    Console.WriteLine("avslut");
                  break;
            


            
                default:

                    Console.WriteLine("nu gick något fel");
                    break;
            
                        
           
            }  





        }






    }
}
