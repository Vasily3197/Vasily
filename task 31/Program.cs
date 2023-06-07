// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]
// 2. Найдите сумму отрицательных и положительных элементов массива.

// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] - сумма положительных чисел равна 29, сумма отрицательный равна -20.

int [] CreatArrayRndInt(int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max+1);
        }
    return arr;
}

void PrintArray (int [] arr, string sep = ",")// string sep = "," - это значение параметра. То есть запятую можно поменять на другой символ
{
    for (int i = 0; i < arr.Length; i++)
    {
    if (i<arr.Length -1) Console.Write($"{arr [i]} {sep}");
    else Console.Write($"{arr[i]}");
    }
}

int [] GetSumPositiveNegativElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;
        for (int i=0; i<arr.Length;i++)
            {
                if(arr[i] > 0) sumPositive +=arr[i];
                else sumNegative += arr [i];
            }
        return new int [] {sumPositive,sumNegative};



}

int GetSumPositiveElem(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0 ) sum += arr [i];
    }
    return sum;
}

int GetSumNegativeeElem(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0 ) sum += arr [i];
    }
    return sum;
}



int [] array = CreatArrayRndInt(12,-9,9);// 12 - это кол-во эллементов, остальное диапазон
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int [] SumPositiveNegativElem = GetSumPositiveNegativElem(array);
Console.WriteLine($"Сумма положительных элементов равна {SumPositiveNegativElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов равна {SumPositiveNegativElem[1]}");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeeElem = GetSumNegativeeElem(array);

Console.WriteLine($"Сумма положительных элементов равна {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegativeeElem}");


