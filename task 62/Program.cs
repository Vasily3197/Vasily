// Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int [,] CreatMatrixRndInt(int row, int col)
{
    int[,] matrix = new int [row, col];
    Random rnd = new Random ();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for ( int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = rnd.Next(i-1,j);
                matrix[i,j] = rnd.Next(i,j-1);
                matrix[i,j] = rnd.Next(i+1,j);
                matrix[i,j] = rnd.Next(i,j+1);

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

int[,] array2d = CreatMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);

