// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] CreatArray(int size, int min, int max)
{
    double [] arr = new double [size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
        {
            arr [i] = rnd.NextDouble();
            double d = rnd.NextDouble();
            arr [i] = Math.Round(d, 2);
        }
    return arr;
}

void PrintArray (double [] arr, string sep = ";")
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


double DoubleMaxElem(double [] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max ) max = arr [i];
    }
    return max;
}

double DoubleMinElem(double [] arr)
{
    double min = 7;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min ) min = arr [i];
    }
    return min;
}

double [] array = CreatArray(7,-7,7);

double max = DoubleMaxElem(array);
double min = DoubleMinElem(array);

PrintArray(array);


Console.WriteLine($"Максимальный элемент массива  {max}");
Console.WriteLine($"Минимальный элемент массива {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
