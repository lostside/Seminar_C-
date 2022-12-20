// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)





int [,,] sheets = new int[2,2,2];
int number = 10;

for (int i = 0; i < sheets.GetLength(0); i++)
{   
    for (int j= 0; j < sheets.GetLength(1); j++)
    {
        for (int k = 0; k < sheets.GetLength(2); k++)
        {
            sheets[i,j,k] = number;
            number++;
            Console.WriteLine($"{sheets[i,j,k]} ({i}, {j}, {k})");
        }
    }
    
}
