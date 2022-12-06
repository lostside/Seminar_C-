// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());


int part1 = n / 10000; // 1
int part2 = (n / 1000) % 10; // 2е число
int part3 = n % 10; // 5 число
int part4 = ( n % 100) / 10; // 4 число

if( part1 == part3 && part2 == part4)
{
    Console.WriteLine("Это палиндром!");
}
else
{
    Console.WriteLine("Не палиндром");
}
