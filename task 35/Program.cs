// 1. Задайте одномерный массив на 123 случайных числа.
// 2. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

// [5,18,123,6,2] -> 1
// [1,2,3,6,2] -> 0
// [10,11,12,13,13] -> 5

int [] CreatArray(int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max+1);
        }
    return arr;
}

void PrintArray (int [] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
    if (length -i > 1) 
        Console.Write($"{arr [i]},");
    else 
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountTwoDig(int[] arr)
{
    int count = 0;
    for (int i = 0; i<arr.Length; i++)
        {
            if (arr[i] >= 10 && arr[i] <= 99) count += 1;
        }
    return count;
}

int[] array = CreatArray(10,0,100);
PrintArray(array);
int count = CountTwoDig(array);
Console.Write ($"->{count}");