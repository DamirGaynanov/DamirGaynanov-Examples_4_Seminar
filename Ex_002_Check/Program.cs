Console.WriteLine("Введите число a");
string a = Console.ReadLine() ?? "";
int a1= int.Parse(a);
Console.WriteLine("Введите число b");
string b = Console.ReadLine() ?? "";
int b1= int.Parse(b);

if (b1 * b1 == a1)
    {
    Console.WriteLine("Число a является квадратом числа b");
    }
else
    {
    Console.WriteLine("Число a не является квадратом числа b");
    }