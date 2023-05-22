// Напишите программу, которая: 
// 1. На вход принимает два числа
// 2. Выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Здравствуйте! Что бы определить, какое из двух чисел большее, а какое меньшее, введите, пожалуйста число a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Теперь введите число b");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (a>b) max = a;
else
{
    max = b;
}

if (a>b) min = b;
else
{
    min = a;
}

Console.Write ($"Наибольшее, из введеных Вами чисел, равно {max}, а наименьшее - {min}");
