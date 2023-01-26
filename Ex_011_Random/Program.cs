// Input data

int number = new Random().Next(100, 1000);
Console.WriteLine($"{number}");
int newNum = RemoveSecondDigit(number);
Console.WriteLine($"{newNum}");

// Метод
int RemoveSecondDigit(int num)
{
    int firstDigit = (num / 100);
    int thirdDigit = (num % 10);
    int result = ((firstDigit*10) + thirdDigit);
    return result;
}