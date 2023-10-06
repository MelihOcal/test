

using System;

for (int i = 0; i < 101; i++)
{
    if (i % 15 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
   
 

    else
    {
        Console.WriteLine(i);
    }




}



