// Напишите программу, которая:

// 1. На вход принимает два числа
// 2. Проверяет проверяет, является ли первое число квадратом второго

// a = 25, b = 5 -> Да 
// a = 2, b = 10 -> Нет
// a = 9, b = -3 -> Да 
// a = -3, b = 9 -> Нет

Console.WriteLine("Введите, пожалуйста, целое число А, а я скажу Вам, является ли оно кватратом целого числа B, или нет");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Теперь, введите целое число B");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberB == numberA * numberA)
{
    Console.WriteLine($"Да, {numberB} - это квадрат числа {numberA} ");
}
else 
{ 
Console.WriteLine($"Нет, {numberB} - это не квадрат числа {numberA} "); 
}
