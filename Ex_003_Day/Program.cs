// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
string a = Console.ReadLine() ?? "";
int a1 = int.Parse(a);
if (a1 == 1)
{
    Console.WriteLine("Monday");
}

if (a1 == 2)
{
    Console.WriteLine("Tuesday");
}

if (a1 == 3)
{
    Console.WriteLine("Wednesday");
}

if (a1 == 4)
{
    Console.WriteLine("Thursday");
}

if (a1 == 5)
{
    Console.WriteLine("Friday");
}