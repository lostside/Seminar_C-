// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void Reverse(int[] array)
{
    for( int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length- i - 1];
        array[array.Length - 1 - i] = temp;
    }
}

void Foo(int b)
{
    b = 5;
}

const int SIZE = 6; // размер массива
const int LEFTRANGE = 0;
const int RIGHTRANGE = 150;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");

Reverse(arr);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", arr)}]");

int number = 10;
Console.WriteLine(number);
Console.WriteLine();
Foo(number); // измения не произойдут.
Console.WriteLine(number);

