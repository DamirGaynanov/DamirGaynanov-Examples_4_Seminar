// Задача 26: 
// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

// Например:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int number = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine(number/10);
int numbersOfDigit = NumbersOfDigit(number);
Console.WriteLine($"Количество цифр в числе {number} -> {numbersOfDigit}");
// Метод
int NumbersOfDigit(int num)
{
    int amount = 0;
    for (int i = 1; num > 0; i++)
    {
        num = num / 10;
        amount = i;
    }
    return amount;
}