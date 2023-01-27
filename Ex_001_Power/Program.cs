Console.WriteLine("Введите число");
string a = Console.ReadLine() ?? "";
int b= int.Parse(a);
//int number = Convert.ToInt32(Concole.ReadLine());
Console.WriteLine(b + "^2="+ b * b);
// Console.WriteLine($"Квадрат числа {number} = {square}");