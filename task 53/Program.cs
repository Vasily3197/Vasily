// 1. Задайте двумерный массив.
// 2. Напишите программу, которая поменяет местами первую и последнюю строку массива.

 int [,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int [rows, columns];
    Random rnd = new Random ();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for ( int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = rnd.Next(min, max+1);
            }
        }
    return matrix;
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine("|");
    }
}



void Swap(int [,] arr)
{
    int Up = 0;
    int down = arr.GetLength(0)-1;
        for(int i = 0; i < arr.GetLength(0) - 1; i++)
        {
            int temp = arr [Up, i];
            arr[Up, i] = arr [down, i];
            arr [down, i] = temp;
        }
}


int[,] array2d = CreatMatrixRndInt(3, 4, 10, 15);
PrintMatrix(array2d);
Console.WriteLine();
Swap(array2d);
Console.WriteLine();
PrintMatrix(array2d);
