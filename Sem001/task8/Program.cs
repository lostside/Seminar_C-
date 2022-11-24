// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите начальное число");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < number; i = i + 2)
if (i % 2 == 0)
{
 Console.Write(i + " ");
}



// int n = 5;
//for ( int i = 0; i < n; i++) от 0 до n

// int n = 5;
// int i = 0;
// while (i > n)
// {
//     Console.WriteLine(i);
//     i++;
// }
// В for инкремент цикла всегда одинаковый, а в while может быть разный по ситуации