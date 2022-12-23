// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// break для остановки цикла
int m=0;
string s = "stop";
string q = m.ToString();
int count = 0;
Console.WriteLine("Введите число");
m = Convert.ToInt32(Console.ReadLine());
if (q == s)
//{   
    //count = count + 1;

    else
        Console.WriteLine($"Количество положительных элементов {count}");
        //break;
           
//}