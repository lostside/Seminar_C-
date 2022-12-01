// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и 
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] collection = new int[new Random().Next(10, 12)];
int i = 0;
while (i <= (collection.Length -1))
{
    collection[i] = new Random().Next(0,2);
    i ++;
}

Console.WriteLine(string.Join(", ", collection));
