// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
string num = Console.ReadLine() ?? "";
int a = int.Parse(num);
if (a == 1)
{
    Console.WriteLine("Monday");
}

else if (a == 2)
{
    Console.WriteLine("Tuesday");
}

else if (a == 3)
{
    Console.WriteLine("Wednesday");
}

else if (a == 4)
{
    Console.WriteLine("Thursday");
}

else if (a == 5)
{
    Console.WriteLine("Friday");
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}