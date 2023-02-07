// Задача 24: 
// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// Например
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
int sumNum = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNum}");

// Метод
// int Sum(int num)
// {
//     int count = 1;
//     int result = 0;
//     while (count <= num)
//     {
//         result = result + count;
//         count++;
//     }
//     return (result);
// }

int SumNumbers (int num)
{
    int sumnum = 0;
    for (int i = 1; i <= num; i++)
    {
        // sumnum = sumnum + i;
        sumnum +=i;
    }
    return sumnum;
}