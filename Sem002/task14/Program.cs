


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
//
// 14 -> нет
// 45 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit % 7 == 0 && digit % 23 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратны");
}
