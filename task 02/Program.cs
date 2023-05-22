// Напишите программу, которая: 
// 1. На вход принимает два числа
// 2. Выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Здравствуйте! Что бы определить, какое из двух чисел большее, а какое меньшее, введите, пожалуйста число a");
double a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Теперь введите число b");
double b = Convert.ToInt32(Console.ReadLine());

double max = a;
double min = b;

if (a>max) max = a;
else
{
    max = b;
    min = a;
}

Console.Write ($"Наибольшее, из введеных Вами чисел, равно {max}, а наименьшее - {min}");
