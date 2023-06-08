// 1. Задайте массив.
// 2. Напишите программу, которая определяет, присутствует ли данное число в массиве.

// 4; массив [6,7,19,345,3] - > нет
// 3; массив [6,7,19,345,3] - > да


// Напишите программу замены элементов массива: положительные элементы на соответствующие отрицательные и наоборот.
// [-4,-8,8,4] -> [4,8,8,4]


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

bool ContainsNumber(int[] arr, int num)
{
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

int [] array = CreatArray(10,-10,10);

Console.WriteLine("Здравтсвуйте! Введите, пожалуйста число, а я скажу, если оно в массиве, или нет");
int number = Convert.ToInt32(Console.ReadLine()); 
PrintArray(array);

Console.WriteLine(ContainsNumber(array,number) ? $"Массив содержит число {number}" : $"Массив не содержит число {number}");