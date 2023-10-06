using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {





            Console.WriteLine("Börja med att presentera dig själv");
            Console.WriteLine("vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine(" Hej " +  namn  + " välkommen");
            
            bool minbool = true;

            while (minbool)
            { 
            switch 
       


            {
                case 1:
                        Console.WriteLine("vad får dig att må bra?");
                        Console.ReadLine();
                        break;



                case 2:
                        Console.WriteLine("vad får dig att må dåligt?");
                        Console.ReadLine();
                    break;



                case 3:


                    minbool = false;
                    break;

                default:

                    Console.WriteLine("Nu gick något fel");
                    break;
                        }









            }
        }
    }
}
