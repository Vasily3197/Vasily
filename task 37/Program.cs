// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент второй и предпоследний и т.д.
// Запишите результат в новом массиве. 

// [1 2 3 4 5] -> 5 8 3
// [6 7 36] -> 36 21

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

int[] MultiplyElements (int[] arr)
{
    int newLength = arr.Length / 2;
    if (arr.Length %2 == 1) newLength += 1;
    int[] newArr = new int[newLength];

    for (int i = 0; i< arr.Length/2; i++)
    {
        newArr[i] = arr[i]*arr[arr.Length - 1-i]; 
    }
    if (arr.Length %2 == 1) newArr[newLength-1] = arr[arr.Length/2];
    return newArr;
}

int[] array = CreatArray(8,0,10);
PrintArray(array);
int[] array2 = MultiplyElements(array);
PrintArray(array2);