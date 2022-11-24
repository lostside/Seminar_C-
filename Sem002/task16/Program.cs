// Напишите программу, которая принимает на вход 2 числа и проверяет, 
// является ли одно число квадратом другого

// 5 и 25 -> да
// -4 и 16 -> да
// 8 и 9 -> нет

Console.WriteLine("Введите первое число");
int digit1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int digit2 = Convert.ToInt32(Console.ReadLine());

if (digit2 == digit1 * digit1)
{
    Console.WriteLine($"{digit2} является квадратом {digit1}");
}
else
{
    Console.WriteLine($"{digit2} не является квадратом {digit1}");
}