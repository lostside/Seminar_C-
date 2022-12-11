// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    Random rand = new Random();

    for ( int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // rightRange + 1 = включая последний элемент
    }
    
    return array;

}

const int SIZE = 4; // размер массива
const int LEFTRANGE = 1;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");


int[] collection = new int[(arr.Length / 2 + arr.Length % 2)]; // проверка масива на четность и создание


for (int i = 0; i < arr.Length / 2; i ++)
{
    collection[i] = arr[i] * arr[arr.Length -1 - i]; // без - i, постоянно будем умножать на последний элемент
    
}
if (arr.Length % 2 != 0)
{
    collection[collection.Length - 1] = arr[2];
}
Console.WriteLine($"[{string.Join(", ", collection)}]");

