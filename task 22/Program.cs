// Напишите программу, которая:
// 1. Принимает на вход число N. 
// 2. Выдааёт таблицу квадратов чисел от 1 до N.

// 5 -> 1,4,9,16,25
// 2 -> 1,4


Console.WriteLine("Здравствуйте! Введите, пожалуйста, число, а я выдам Вам таблицу квадратов от 1 до Вашего числа");
int num = Convert.ToInt32(Console.ReadLine());




sqr(num);
void sqr(int n)
{
    int count = 1;
        while (count <= n)
        {
        Console.WriteLine($"{count*count}");
        count++;
        }
}