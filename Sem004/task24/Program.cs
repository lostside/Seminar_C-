// Задача 24: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


bool Validate(int number)
{
    if (number > 1)
    {
        return true;
    }
    else{
        return false;
    }
}

int sum1toA(int A)
{
    int sum = 0; // объявляем вне цикла, так как в цикле будет обнуляться
    for (int i = 1; i <= A; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}

int GetNumber(string message) // Метод для ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetNumber("Введите число");
bool IsCorrect = Validate(number);
if (IsCorrect == true)
{
    int summa = sum1toA(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {summa}");
}
else
{
    Console.WriteLine($"Невозможно получить сумму от 1 до {number}");
}