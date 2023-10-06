using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<string> zmarej = new List<string> { "hund ", " valp"," svamp", " kurd ", " flash, " };
            
            
           


            Console.Write(zmarej[0]);
            Console.Write(zmarej[1]);
            Console.Write(zmarej[2]);
            Console.Write(zmarej[3]);
            Console.Write(zmarej[4]);





            foreach(string zma in zmarej)
         
            {
                Console.WriteLine(zma);
                Console.ReadLine();
            
            }

        }
    }
}
