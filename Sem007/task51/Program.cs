// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=9)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange,rightRange + 1); // вместо 
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(i == j)
            {
                sum += matr[i,j];
            } 
        }
    }
    return sum;
}


void PrintMatrix(int [,] matr) // Вывод матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++) // i < matrix.GetLenght(0). Этот цикл для строк
    {
        for( int j = 0; j < matr.GetLength(1); j++) // j < matrix.GetLength(1). Этот для столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

int rows = GetNumber("Введите число строк");
int columns = GetNumber("Введите число столбцов");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
int sum = GetSum(matrix);
Console.WriteLine(sum);

int GetSumSecond(int[,] matr)
{
    int sum = 0;
    int length = 0;
    if (matr.GetLength(0) > matr.GetLength(1))
    {
        length = matr.GetLength(1);
        // for (int i = 0; i < matr.GetLength(1); i++)
        // {
        //     sum += matr[i,i];
        // }
    }
    else
    {
        length = matr.GetLength(1);
        // for (int i = 0; i < matr.GetLength(0); i++)
        // {
        //     sum += matr[i,i];
        // }
    }
    for (int i = 0; i < length; i++)
    {
        {
            sum += matr[i,i];
        }
    }
    return sum;
}
