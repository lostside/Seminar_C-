// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


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
// true - элемент найден, false - элемент не найден
bool isNumberinArray(int[] array, int findNumber)
{
    bool res = false; // изначально думаем, что элемента в массиве нет
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == findNumber)
        {
            res = true;
            break;
        }
    }
    return res;
}

const int SIZE = 12; // размер массива
const int LEFTRANGE = -10;
const int RIGHTRANGE = 10;
const int FINDNUMBER = 5;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");
bool result = isNumberinArray(arr, FINDNUMBER);
Console.WriteLine($"Ищем цифру {FINDNUMBER}");
if (result == true)
{
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("нет");
}