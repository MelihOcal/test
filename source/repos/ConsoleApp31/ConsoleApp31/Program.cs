// See https://aka.ms/new-console-template for more information
int våning = 1;

Console.WriteLine("mata in ett riktig våning ");

int fakeFloor = 0;

int i = Convert.ToInt32(Console.ReadLine());

while (våning < i)
{
    våning++;


    if (våning == 4)
    {
        fakeFloor--;
    }
    if (våning == 13)
    {
        Console.WriteLine("kan ej omvandla till riktigt våningsnummer");
    }
    
}

Console.WriteLine("ditt riktiga våning är " + (våning + fakeFloor));
