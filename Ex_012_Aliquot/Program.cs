// Задача

// //Напишите программу, которая будет принимать на вход два число ивыводить, 
// является ли первое число кратным второму. Если число 1 не кратно числу 2, 
// то программа выводит осток от деления.

//___________________________________________________________________________

Console.WriteLine("Введите число №1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2:");
int number2 = Convert.ToInt32(Console.ReadLine());
int aliquot = Aliquot(number1, number2);

//Метод
int Aliquot(int num1, int num2)
{
    int rest = (num1 % num2);
    if (num1 % num2 == 0) Console.WriteLine($"{num1}, {num2} -> Кратно");
    else Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {rest}");
    return rest;
}


// int remains = Remains(number1, number2);
// string result1 = "БЕ";
// int result = remains > 0 ? result1 : remains;
// Console.WriteLine($"Кратно {result}");

// int Remains(int num1, int num2)
// {
//     return num1 % num2;
// }