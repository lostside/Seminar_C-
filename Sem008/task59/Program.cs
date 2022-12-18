// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1); // вместо 
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matr) // Вывод матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++) // i < matrix.GetLenght(0). Этот цикл для строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // j < matrix.GetLength(1). Этот для столбцов
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


int[,] Deletting(int[,] matr)
{
    int minI = -1;
    int minJ = -1;
    int min = 999;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min) // нахождение индекса минимального элемента
            {
                minI = i;
                minJ = j;
                min = matr[i, j];
            }
        }
    }
    int[,] result = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int ii = 0;
    int jj = 0;
    Console.WriteLine();
    Console.WriteLine("minI = " + minI);
    Console.WriteLine("minJ = " + minJ);
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i !=  minI)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (j != minJ)
                {
                    result[ii, jj] = matr[i, j];
                    jj++;
                }
            }
            jj = 0;
            ii++;
        }
    }
    return result;
}
int[,] res = Deletting(matrix);
PrintMatrix(res);









