﻿Console.WriteLine("Введите число");
string a = Console.ReadLine() ?? "";
int b= int.Parse(a);
Console.WriteLine(b + "^2="+ b * b);