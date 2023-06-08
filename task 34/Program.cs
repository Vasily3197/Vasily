//  1. Задайте массив заполненный случайными положительными трёхзначными числами. 
//  2. Наапишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int ChetnoeChislo (int [] arr)
{
    int Chetnoe = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] %2 == 0) Chetnoe++;
    }
    return Chetnoe;
}


int [] array = CreatArray(10,100,999);
PrintArray(array);
int Chetnoe = ChetnoeChislo(array);

Console.WriteLine($"Здесь {Chetnoe} чётных элементов");




