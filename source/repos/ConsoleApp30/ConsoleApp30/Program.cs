// See https://aka.ms/new-console-template for more information

int våning = 1;

Console.WriteLine("mata in ett riktig våning ");

int fakeFloor = 0;

int i = Convert.ToInt32(Console.ReadLine());

for (våning = 1; våning < i + fakeFloor; våning++)
{
  
    if (våning % 10 == 4)
    {
        fakeFloor++;
    }
    if(våning % 100 == 13)
    {
        fakeFloor++;
    }
}

Console.WriteLine("ditt riktiga våning är " + (våning));