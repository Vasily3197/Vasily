// Пользователь вводит с клавиатуры N чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int GetNumber()
{
    Console.Write("Здравствуйте! Введите числа, а я скажу сколько чисел вы ввели после 0: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] NumbersInput(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountGreaterThanZero(int[] arr)
{
    int count = 0;
    foreach (int num in arr)
    {
        if (num > 0) count++;
    }
    return count;
}

int number = GetNumber();

if (number < 1)
{
    Console.WriteLine("");
    return;
}

int[] array = NumbersInput(number);
Console.WriteLine($"Вы ввели {CountGreaterThanZero(array)} после нуля");