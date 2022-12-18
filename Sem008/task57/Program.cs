// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

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


int[] Dictionary(int[,] matr)
{
    int[] result = new int[10];
    for (int i = 0; i < matr.GetLength(0); i++)
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            result[matr[i,j]]++;
        }
    }
    return result;
}

Console.WriteLine(string.Join(", ", Dictionary(matrix)));
int[] res = Dictionary(matrix);
for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(i + " встречается " + res[i] + " раз");
    
}