// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello and welcome please type in your name and age!");

string namn = Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("hello " + namn + " you are too young");

}
else if (age >= 18)
{
    Console.WriteLine("Welcome!");
}





