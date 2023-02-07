// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8]; // 0, 1, 2, 3, 4, 5, 6 ,7
// array[0] = new Random().Next(0,2);

int[] arr = CreateArray(8);
PrintArray(arr);

int[] CreateArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length ; i++)
    {
        Console.Write ($"{array[i]} ");
    }
}