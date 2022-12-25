// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// break для остановки цикла
string s = "stop";

int[] collection = new int[10];
int count = 0;

for (int i = 0; i < collection.Length; i++)
{
    Console.WriteLine("Введите число ");
    collection[i] = Convert.ToInt32(Console.ReadLine());
    if (collection[i] > 0)
    {
        count++;
    }
    


}
Console.WriteLine("Чисел больше 0 = " + count);
