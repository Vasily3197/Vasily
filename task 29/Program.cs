// Напишите программу, которая:
// 1. Задаёт массив из 8 элементов
// 2. Выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length || i > array.Length; i++)
    {
        array[i] = new Random().Next(999);
    } 
}

void PrintArray(int[] array)
{
    for (int i = 0;i < array.Length || i > array.Length; i++)
    {
        Console.WriteLine(array[i] + "  ");
    }
}

int [] array1 = new int [8];
FillArray(array1);
PrintArray(array1);