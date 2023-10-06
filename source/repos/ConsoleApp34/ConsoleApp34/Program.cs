// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




Console.WriteLine("Type a day");
int input = Convert.ToInt32(Console.ReadLine());

switch(input)
{
    case 0:
        Console.WriteLine("its thursday");
        break;
    case 1:
        Console.WriteLine("its friday");
        break;
    case 2:
        Console.WriteLine("its saturday");
        break;
    case 3:
        Console.WriteLine("its sunday");
        break;
    case 4:
        Console.WriteLine("its monday");
        break;

    default:
        Console.WriteLine("type in a valid day");
        break;

}

Console.ReadLine();

