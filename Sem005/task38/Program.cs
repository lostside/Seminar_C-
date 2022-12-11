// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

const int SIZE = 5; // размер массива
const int LEFTRANGE = 0;
const int RIGHTRANGE = 12;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");
int i = 0;
int maxArr = arr[0];
int minArr = arr[i];
for(i = 1; i < arr.Length; i++)
{
    if (arr[i] > maxArr)
    {
        maxArr = arr[i];
    }
      
}
for(i = 1; i < arr.Length;i++)
{
    if(arr[i] < minArr )
    {
        minArr = arr[i];
    }
}
int diffMaxMin = maxArr - minArr;
Console.WriteLine($"Максимальное значение массива {maxArr} - Минимальное значение массива {minArr}. Разница между значениями равна {diffMaxMin}");