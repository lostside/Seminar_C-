// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите три длины треугальника");
Console.WriteLine("Введите сторону a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону c");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < b + a)
{
    Console.WriteLine("Такой треугольник реален!");
}
else
{
    Console.WriteLine("Теорема о неравенстве доказана!");
}

