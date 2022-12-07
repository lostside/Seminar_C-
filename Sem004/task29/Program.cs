// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем


int[] collection = new int[8];


for (int i = 0; i < collection.Length; i ++)
{
    Console.Write("Введите элемент массива: ");
    collection[i] = Convert.ToInt32(Console.ReadLine());
}
    

Console.WriteLine(string.Join(", ", collection));
