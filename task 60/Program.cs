﻿// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 

// Напишите программу, которая: 

// Будет построчно выводить массив, добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

Console.Clear();

 int [,,] CreatMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int [rows, columns, depth];
    Random rnd = new Random ();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for ( int j = 0; j < matrix.GetLength(1); j++)
            {
               for (int k = 0; k < matrix.GetLength(2); k++)
               {
                     matrix[i,j,k] = rnd.Next(min, max+1);
               }
            }
        }
    return matrix;
}

void PrintMatrix (int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++) 
            {
            Console.Write($"{matrix[i,j,k], 5} ");
            }
        }
        Console.WriteLine("|");
    }
}

int[,,] array3d = CreatMatrixRndInt(2, 2, 2, 10, 99);
PrintMatrix(array3d);

