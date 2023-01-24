// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
string a = Console.ReadLine() ?? "";
int a1 = int.Parse(a);
else if (a1 == 1)
{
    Console.WriteLine("Monday");
}

else if(a1 == 2)
{
    Console.WriteLine("Tuesday");
}

else if (a1 == 3)
{
    Console.WriteLine("Wednesday");
}

else if (a1 == 4)
{
    Console.WriteLine("Thursday");
}

else if (a1 == 5)
{
    Console.WriteLine("Friday");
}
else 
{
    Console.WriteLine("Введите число от 1 до 7");
}