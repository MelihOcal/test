// See https://aka.ms/new-console-template for more information

Console.WriteLine("how old are you?");

int age = Convert.ToInt32(Console.ReadLine());

if (age <= 18)
{
    Console.WriteLine("you are too young");
}
else 
{
    Console.WriteLine("welcome");

}

Console.ReadLine();
