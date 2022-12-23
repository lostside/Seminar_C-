// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ​
// 645 -> 5
// ​
// 78 -> третьей цифры нет
// ​
// 32679 -> 6

// через цикл решать


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int rez = 1;

if (n >= 100){
    while (n > 999)
    {
        n = n / 10;
    }
    rez = n % 10;
}
if (n < 99)
{
    Console.WriteLine("Такой цифры нет");
}
else
Console.WriteLine(rez);

