//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// x, y -> namespace 

// 1: x > 0 && y > 0
// 2: x < 0 && y > 0
// 3: x < 0 && y < 0
// 4: x > 0 && y < 0


Console.WriteLine("Введите координату по X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}
else
{
    Console.WriteLine("Невозможно определетить координатную четверть");
}