// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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

const int SIZE = 12; 
const int LEFTRANGE = -10;
const int RIGHTRANGE = 10;

// int ReverseArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] * - 1;
//     }

//     return arr;
// }
int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");

for (int i = 0; i < SIZE; i++)
{
    arr[i] = arr[i] * - 1;
}

// int[] rvsArr = ReverseArray(arr);
// Console.WriteLine(string.Join(",", rvsArr));
Console.WriteLine($"[{string.Join(", ", arr)}]");

//Задать вопрос по методу!!!!