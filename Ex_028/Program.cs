// Задача 28: 
// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 
// Например:
// 4 -> 24
// 5 -> 120
// ___________________

Console.WriteLine("Введите число");
int number;
if (int.TryParse(Console.ReadLine(), out number))
{
    if (number > 0)
        {
            int factorial = Factorial(number);
            Console.WriteLine(factorial);
        }
    else
        {
            Console.WriteLine("Введено некорректное значение. Введите натуральное число");
        }
}
else
    {
        Console.WriteLine("Введено некорректное значение. Введите натуральное число");
    }



// Метод
int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}
