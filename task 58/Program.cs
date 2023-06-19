// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] CreatMatrixRndInt1(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] CreatMatrixRndInt2(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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



int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    if (!MultiMatrix(matrix1, matrix2)) return null!;

    int common = matrix1.GetLength(1);
    int rowPro = matrix1.GetLength(0);
    int coluPro = matrix2.GetLength(1);
    int[,] multiplication = new int[rowPro, colPro];

    for (int i = 0; i < rowPro; i++)
    {
        for (int j = 0; j < colPro; j++)
        {
            for (int k = 0; k < common; k++)
            {
                multiplication[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return multiplication;
}

int[,] array1 = CreatMatrixRndInt1(2, 2, 10, 99);
Console.WriteLine();
int[,] array2 = CreatMatrixRndInt2(2, 1, 10, 99);
PrintMatrix(array1);
Console.WriteLine();
PrintMatrix(array2);

