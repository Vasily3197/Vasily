// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

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


int SumNechet(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length;i+=2)
    {
        sum  = sum + arr [i];    
    }
    return sum;
}


int [] array = CreatArray(7,-7,7);
PrintArray(array);

int sum = SumNechet(array);

Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");
