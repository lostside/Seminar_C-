﻿// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] arr = {1,2,3,44,5,6};

int[] arr2 = new int[arr.Length];

for(int i = 0; i < arr.Length;i++)
{
    arr2[i] = arr[i];
}
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine($"[{string.Join(", ", arr2)}]");