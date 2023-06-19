// Задайте двумерный массив из целых чисел.
// Напишите программу, которая:
// Удалит строку и столбец на пересечении которых расположен наименьший элемент массива.


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

int [] IMin (int [,] matrix)
{
    int min = matrix[0,0];
    int [] result = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); i++)
        {
            if (matrix [i,j] < min)
            {
                min = matrix [i,j];
                result [0] = i;
                result [1] = j;
            } 
        }
    }
    return result;
}

int [,] Remove(matrix[,])



int[,] array2d = CreatMatrixRndInt(4, 4, 10, 15);
PrintMatrix(array2d);
