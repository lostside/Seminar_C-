// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9
Random rand = new Random();
//Console.WriteLine($"{rand.NextDouble() *(13.0 + 7.0) - 7.0:f2}");
// rand.NextDouble() * (maxValue + minValue) + minValue

double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=50)
{
    double[,] matr = new double[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Convert.ToDouble(rand.NextDouble()*(10 + 9) - 7.0);
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
double[,] matrix = GetMatrix(rows, columns);
// Console.WriteLine();
PrintMatrix(matrix);

void PrintMatrix(double [,] matr) // Вывод матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++) // i < matrix.GetLenght(0). Этот цикл для строк
    {
        for( int j = 0; j < matr.GetLength(1); j++) // j < matrix.GetLength(1). Этот для столбцов
        {
        
            Console.Write($"{matr[i, j]:f2} ");
        }
    Console.WriteLine();
    }
}
