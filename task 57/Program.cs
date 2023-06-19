// Составить частотный словарь элементов двумерного массива.
// Частостный словарь содержит информацию о том, сколько раз встречается элемент вводных данных.

// Набор данных                    Частостный массив

// {1,9,9,0,2,8,0,9}               0 встречается 2 раза
//                                 1 встречается 1 раза
//                                 2 встречается 1 раза
//                                 8 встречается 1 раза
//                                 9 встречается 3 раза

                                
// 1,2,3                           
// 4,6,1
// 2,1,6                           1 встречается 3 раза
//                                 2 встречается 2 раза
//                                 3 встречается 1 раза
//                                 4 встречается 1 раза
//                                 6 встречается 2 раза


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

int [] MArray (int [,] matrix)
{
    int k = 0;
    int [] array = new int [matrix.Length]; 
        for ( int i = 0; i < matrix.GetLength(0); i++)
        {
            for ( int j = 0; j < matrix.GetLength(1); j++)
            {
                array [ k ] = matrix [i,j];
                k++;
            }    
        }
    return array;
}

void PrintArray (int [] arr, string sep = ",")
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
    if (length -i > 1) 
        Console.Write($"{arr [i]} {sep}");
    else 
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void  CountFreq(int array)
{
    int currentNum = array[0];
    int count = 1; 
        for ( int i = 1; i < array.Length; i++)
        {
            if (array [i] == currentNum) count++;
            else
            {
                Console.WriteLine($"Число {currentNum} встречается {count} раз");
                currentNum = array[i];
                count = 1;
            }
        }
    Console.WriteLine($"Число {currentNum} встречается {count} раз");

}

int[,] array2d = CreatMatrixRndInt(4, 4, 1, 9);
int [] array = MArray(array2d);
Array.Sort(array);

PrintMatrix(array2d);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
CountFreq(array);



