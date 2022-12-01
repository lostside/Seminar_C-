// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumber(string message) // Метод для ввода числа
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}

int Res(int num)
{
    int res = 0;
    int i = 0;
    for (i = 1; i >0 num; i++)
    {
        res = res / 10;
       
    }
    // while(num>0) 
    // {
    // num /= 10;
    // i++;
    // }
    return res;
}

int number = GetNumber("Введите число");
int count = Res(number);
Console.WriteLine(count);



