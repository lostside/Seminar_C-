// Задача 22: Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N; i++)
{
    double sqr = Math.Pow(i, 2);
    Console.Write(sqr + ", ");
}
Console.Write(Math.Pow(N, 2));

// for (int i = 2; i < number; i = i + 2)
// if (i % 2 == 0)
// {
//  Console.Write(i + " ");
// }