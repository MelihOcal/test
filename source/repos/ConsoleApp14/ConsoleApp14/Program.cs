using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {

        static int addera(int tal1, int tal2)
        {
            int summa = tal1 + tal2;
            return summa;
        }


        

        
        static void Main(string[] args)
        {
            Console.WriteLine(addera(10, 10));
            Console.ReadLine();
        }
    }
}
