// Напишите программу, которая:
// Выводит массив из 8 элементов, заполненный нулями и еденицами в случайном порядке. 

// [0,1,,1,1,0,0]

//int [] array = new  int [8]; // Пустой массив с 8 элементами, заполненный нулями
//int size = array.Length; // рзамер массива - 8

// array[0] =  // значение массива

//int rnd = new Random().Next();

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    } 
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + "  ");
    }
}

int [] array1 = new int [8];
FillArray(array1);
PrintArray(array1);