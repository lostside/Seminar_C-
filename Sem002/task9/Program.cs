// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100); // в данном случае 99 не будет в диапозоне. нужно указать 100

Console.WriteLine(number);
int digit2 = number % 10; // узнаем вторую цифру - 78 % 10 = 8 (остаток от деления)
int digit1 = number / 10; // 78 / 10 = 7.8 . А так как это не double - то 

Console.WriteLine($"Первая цифра = {digit1}, вторая цифра = {digit2}");

if (digit1 > digit2)
{
    Console.WriteLine($"Максимальная цифра = {digit1}");
}
else
{
    Console.WriteLine($"Максимальная цифра = {digit2}");
}