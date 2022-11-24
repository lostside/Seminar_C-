// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000); 

Console.WriteLine(number);

int digit2 = number % 10; 
int digit1 = number / 100;

Console.WriteLine(digit1);
Console.WriteLine(digit2);

Console.WriteLine($"Искомое число = {digit1 * 10 + digit2}");