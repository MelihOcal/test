// See https://aka.ms/new-console-template for more information

int ruta = 1;
int riskornpåruta = 1;
Console.WriteLine("hur många riskorn vill du ha?");

int i = Convert.ToInt32(Console.ReadLine());


// ruta 1 = 1 ris, ruta 2 = 2 ris, ruta 3 = 4 ris, ruta 5 = 16 ris, ruta 6 = 32
// ruta 7 = 64, ruta 8 = 128, ruta 9 = 256, 


while (riskornpåruta < i)
{

    ruta++;
    riskornpåruta *= 2;

}

Console.WriteLine("ruta " + ruta + " har minst så många riskorn du vill ha");



