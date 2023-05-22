// Напишите программу, которая: 
// 1. Принимает на вход три числа
// 2. Выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Здравствуйте! Что бы определить, какое из трёх, введёных Вами, чисел больше, введите первое");
double a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Отлично! Теперь второе");
double b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("И, наконец, третье");
double c = Convert.ToInt32(Console.ReadLine());

double max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;

Console.Write ($"Наибольшее, из введеных Вами чисел, равно {max}");
