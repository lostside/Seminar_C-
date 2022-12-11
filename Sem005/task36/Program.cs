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

const int SIZE = 6; // размер массива
const int LEFTRANGE = -9;
const int RIGHTRANGE = 99;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");
int i = 1;
int sum = 0;
while( i < arr.Length)
{
    if ( i % 2 != 0)
    {
        sum = sum + arr[i];
    }
    i++;
}
Console.WriteLine(sum);
