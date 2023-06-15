﻿// Напишите программу, которая: 
// 1. На вход принимает позиции элемента в двумерном массиве
// 2. Возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


int[,] CreateFillMatrix(int m, int n)
{
    int[,] arr = new int[m,n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j], 4}");
        }

        Console.WriteLine();
    }
}

int[] PromptRowColumn()
{
    int[] rowCol = new int[2]; 
    Console.Write("Введите, пожалуйста, позицию строки: ");
    rowCol[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите, пожалуйста, позицию столбца: ");
    rowCol[1] = Convert.ToInt32(Console.ReadLine());
    return rowCol;
}

bool IsInArray(int row, int column, int[,] arr)
{
    if (row >= arr.GetLength(0) || row < 0 || column >= arr.GetLength(1) || column < 0) return false;
    return true;
}

int[,] array = CreateFillMatrix(4, 4);

int[] rowColumn = PromptRowColumn();
Console.WriteLine();
PrintMatrix(array);

if (IsInArray(rowColumn[0], rowColumn[1], array))
    Console.WriteLine($"На позиции [{rowColumn[0]}, {rowColumn[1]}] значение {array[rowColumn[0],rowColumn[1]]}");
else
Console.WriteLine("Здесь нет таких позиций");
