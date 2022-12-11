// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
const int LEFTRANGE = -9;
const int RIGHTRANGE = 99;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");

int res = 0;
for (int i = 0; i < arr.Length; i++)
{
    for(int j = 1; arr[j] % 2 != 0; j++) //if (arr[i] % 2 != 0)
    {
        res = arr[j] + arr[j + 2];
    }
}

Console.WriteLine(res);
