// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

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

void Replace(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++) // matr.GetLenght(0) - 1 = номер последней строки(я знаал!)
    {
        int tmp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0) -1 , i];
        matr[matr.GetLength(0) - 1, i] = tmp;

    }
}

Console.WriteLine();
Replace(matrix);
PrintMatrix(matrix);