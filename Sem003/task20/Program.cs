// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату x точки A");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки A");
int y = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координату x2 точки B");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2 точки A");
int y2 = Convert.ToInt32(Console.ReadLine());

double z = Math.Sqrt((x2 - x) * (x2 -x ) + (y2 - y) * (y2 - y));

Console.WriteLine($"{z:f2}"); // два знака после запятой

