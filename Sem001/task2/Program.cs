// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, 
//а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.WriteLine(a + " Минимальное число");
}
else
{
    Console.WriteLine(b + " Максимальное число");
}