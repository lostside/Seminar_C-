// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число в десятичной системе исчисления");
int n = Convert.ToInt32(Console.ReadLine());

int Method1(int number)
{
    int i = 0;
    while( number > 0)
    {
        number = number / 2;
        i++;
    }
    return i;

}

int[] collection = new int[Method1(n)];

int b = collection.Length-1;

while (n > 0)
    {
    collection[b] = n % 2;
    n = n / 2;
    b--;
    }

Console.WriteLine(string.Join("", collection));