// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
// ​
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int digit2 = number % 10; 
int digit1 = number / 10;
int digit3 = digit1 % 10;

Console.WriteLine(digit3);

Console.WriteLine($"Искомое число = {digit3}");