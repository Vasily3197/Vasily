// Задайте двумерный массив - Stream 2d array
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0);(1,1)) и т.д.

// 1   4   7   2
// 5   9   2   3
// 8   4   2   4

// Сумма элементовглавной диагонали: 1 + 9+2 = 12


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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine();
    }
}

int GetDS(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum+=matrix[i,j];
            }    
        }
        Console.WriteLine();
    }   
    return sum;
}


int[,] array2d = CreatMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);

Console.WriteLine($"Сумма эллементов на главной диагонали = {+GetDS(array2d)}");

