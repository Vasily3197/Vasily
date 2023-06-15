// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int[,] array2d = CreatMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);

void PrintAverages(double[] arr, int digits = 2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"У столбца с индексом {i} среднее арифмитическое {Math.Round(arr[i], digits)}");
    }
}

double[] GetColumnsAverage(int[,] arr)
{   
    int rows = arr.GetLength(0), columns = arr.GetLength(1);
    double[] averagesCol = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        double sumCol = 0;
        for (int i = 0; i < rows; i++)
        {
            sumCol += arr[i, j];
        }
        averagesCol[j] = sumCol / rows;
    }
    return averagesCol;
}

Console.WriteLine();
PrintAverages(GetColumnsAverage(array2d));