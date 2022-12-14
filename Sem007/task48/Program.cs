// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=50)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j; // вместо rand.Next(leftRange,rightRange + 1)
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int rows = GetNumber("Введите число строк");
int columns = GetNumber("Введите число столбцов");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);

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
