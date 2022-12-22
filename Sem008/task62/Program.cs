// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int n = 4;
int [,] spiral = new int[n,n];

int i = 0;
int j = 0;
int a = 1;

while (a <= spiral.GetLength(0) * spiral.GetLength(1))
{
    spiral[i,j] = a;
    a++;
    if (i <= j + 1 && i + j < spiral.GetLength(1) -1)
    j++;
    else if (i < j && i + j >= spiral.GetLength(0) -1)
    i++;
    else if (i >= j && i + j > spiral.GetLength(1) -1)
    j--;
    else
     i--;

}

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0);i++)
    {
        for (int j = 0; j <array.GetLength(1);j++)
        {
            if (array[i,j] / 10 <=0)
            {
                Console.Write($" {array[i,j]} ");
            }
            else
                Console.Write($"{array[i,j]} ");
            
        }
        Console.WriteLine();
    }
}

FillArray(spiral);