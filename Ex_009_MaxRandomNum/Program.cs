// Методы

// Напишите программу, которая выводит случайное число из отрезка [10...99] и покзывает наибольшую
// Например 70 -> 8

// Input data 
int numrund = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {numrund}");

// int firstDigit = numrund / 10;
// int secondDigit = numrund % 10;

// Decision
// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// Другой метод

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {result}");

int maxDigit1 = MaxDigit(numrund);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");

int maxDigit2 = MaxDigit(56);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");

int maxDigit3 = MaxDigit(79);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit3}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;//num=numrund
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}