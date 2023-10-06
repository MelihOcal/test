using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_struktur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int banan = 0;
            bool minbool = true;
            while (minbool)

                Console.WriteLine("Välj menyval"
                    + "\n1 - lägg till banan"
                    + "\n2 - ´skriv ut antal banan"
                    + "\n3 - avsluta");
            int input  = Convert.ToInt32(Console.ReadLine());
            switch(input)   



            {
                case 1:
                    Console.WriteLine("hur många bananer vill du ha?");
                    banan += Convert.ToInt32(Console.ReadLine());
                    break;



              case 2:

                    Console.WriteLine("du har sparat " + banan + " antal banan");
                    banan += Convert.ToInt32(Console.ReadLine());
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
