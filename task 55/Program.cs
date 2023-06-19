// 1. Задайте двумерный массив.
// 1.1. Напишите программу, которая:
//     1.1.1. Заменяет строки на столбцы.
//     1.1.2. Если это не возможно выводит сообщение.

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
        for(int i = 0; i < arr.GetLength(0) - 1; i++)
    {
            for (int j = i+1; j < arr.GetLength(1) - 1; j++)
        {
            int temp = arr [i, j];
            arr[i, j] = arr [j, i];
            arr [j, i] = temp;
        }
    }
}

bool MatrixSqu( int [,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}


int[,] array2d = CreatMatrixRndInt(4, 4, 10, 15);
PrintMatrix(array2d);

Console.WriteLine();
    if (MatrixSqu(array2d))
    {
        Swap(array2d);
        PrintMatrix(array2d);
    }
    else
    {
        Console.WriteLine("Здесь какая - то ошибка. Возможно матрица не квадратична");
    }