// Задайте двумерный массив размера m на n.
// Каждый элемент массива находится по формуле Amn = m+n
// Выведете полученный массив на экран.

// m = 3, n = 4

// 0123
// 1234
// 2345

 int [,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int [rows, columns];
    Random rnd = new Random ();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for ( int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = i+j;
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
        Console.Write($"{matrix[i,j], 5}  ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2d = CreatMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);