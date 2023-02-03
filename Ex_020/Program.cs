// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату точки А по оси Х: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки А по оси Y: ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату точки В по оси X: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки В по оси Y: ");
double yb = Convert.ToDouble(Console.ReadLine());

double distance = Distance (xa, ya, xb, yb);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));
   

// Метод
double Distance(double x1 , double y1, double x2 , double y2)
{
    double dist = Math.Sqrt((Math.Pow(x2-x1,2))+(Math.Pow(y2-y1,2)));
    return dist;
}

// Math.Pow(2, 10);
// Math.Sqrt(5);
// double d = 5.099753443;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);