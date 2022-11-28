
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// 1: x > 0 && y > 0
// 2: x < 0 && y > 0
// 3: x < 0 && y < 0
// 4: x > 0 && y < 0

Console.WriteLine("Введите  номер координатной четверти");
int quarte = Convert.ToInt32(Console.ReadLine());


if (quarte == 1)
{
    Console.WriteLine("x > 0 и y > 0");
}
else if (quarte == 2)
{
    Console.WriteLine(" x < 0 и y > 0");
}
else if (quarte == 3)
{
    Console.WriteLine(" x < 0 и y < 0");
}
else if (quarte == 4)
{
    Console.WriteLine(" x > 0 и y < 0");
}
else
{
    Console.WriteLine(" Вы ввели не правильный номер четверти");
}