// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int GetNumber(string message) // Метод для ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int A = GetNumber("Введите число A");
int B = GetNumber("Введите степень");
int res = 1;
    for (int i = 1; i <= B; i++)
    {
        res = res * A;
        
    }

Console.WriteLine(res);