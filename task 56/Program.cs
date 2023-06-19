// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая: 
// Будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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



int[,] array2d = CreatMatrixRndInt(3, 3, 10, 99);
PrintMatrix(array2d);
     

 int Sum(int[,] matrixDont)
{
    int smallSum = 0;
    int rowSum = 0;
    for (int i = 0; i < matrixDont.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrixDont.GetLength(1); j++)
        {
            if (i == 0) smallSum += matrixDont[i, j];
            else sum += matrixDont[i, j];
        }

        if (i != 0 && sum < smallSum)
        {
            smallSum = sum;
            rowSum = i;
        }
    }
    return rowSum;
}

Console.WriteLine($"Я посчитал сумму элементов в каждой строке. Номер строки с наименьшей суммой элементов: {Sum(array2d) + 1} строка");