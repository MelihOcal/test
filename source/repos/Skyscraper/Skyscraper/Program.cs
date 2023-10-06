using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyscraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var E = 1;

            while (E <= 102)
            {

                if ((E - 4) % 10 != 0 && (E - 13) % 100 != 0)
                {
                    Console.WriteLine(E);
                }

                E = E + 1;
            }

            Console.ReadLine();
        }
    }
}
