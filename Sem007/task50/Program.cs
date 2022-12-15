// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет. ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет
// Ищем элемент, на позиции [1,7]


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
int EnterPos(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
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

int posRow = EnterPos("введите номер строки");
int posCol = EnterPos("введите номер столбца");

if (posRow > matrix.GetLength(0) || posCol > matrix.GetLength(1))
{
    Console.WriteLine("Такого числа вмассиве нет");
}
else
{
    Console.WriteLine($"Значение элемента = {matrix[posRow,posCol]}");
}
