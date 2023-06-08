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

void ChangeSign (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] *= -1;
    }
}


int [] array = CreatArray(10,-10,10);

PrintArray(array);
ChangeSign(array);
PrintArray(array);


