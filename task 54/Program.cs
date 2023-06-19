// Задайте двумерный массив. 
// Напишите программу, которая 
// Упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

void Sort(int[,] sort)
{
    for (int i = 0; i < sort.GetLength(0); i++)
    {
        int length = sort.GetLength(1);
        for (int j = 0; j < length - 1; j++)
        {
            for (int k = 0; k < length - j - 1; k++)
            {
                if (sort[i, k] < sort[i, k + 1])
                {
                    int temp = sort[i, k];
                    sort[i, k] = sort[i, k + 1];
                    sort [i, k + 1] = temp;
                }
            }
        }
    }
}


int[,] array2d = CreatMatrixRndInt(2, 2, 10, 99);
PrintMatrix(array2d);
Console.WriteLine();
Sort(array2d);
PrintMatrix(array2d);