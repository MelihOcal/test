// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;



var floor = 1;

while (floor != 500)
{

    if ((floor - 4) % 10 == 0)
    {
        Console.WriteLine(floor);
    }
    else if ((floor - 13) % 10 == 0)
    {
        Console.WriteLine(floor);
    }
    floor = floor + 1;
}