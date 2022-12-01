// Задача 28: Напишите программу, которая принимает на
//  вход число N и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

bool Validate(int number)
{
    if (number > 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int Factorial(int A)
{
    int fact = 1; // объявляем вне цикла, так как в цикле будет обнуляться
    for (int i = 1; i <= A; i++)
    {
        //sum = sum + i;
        fact = fact * i ;
    }
    return fact;
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
    int factor = Factorial(number);
    Console.WriteLine($"Факториал числа {number} = {factor}");
}
else
{
    Console.WriteLine($"Невозможно получить факториал {number}");
}