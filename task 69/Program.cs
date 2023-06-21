// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

double PowerRec(int num, int pow)
{
    return (pow == 0) ? 1 : num * PowerRec(num, pow - 1);
}

Console.WriteLine("Введите два натуральных числа, а я возведу первое число в степеь второго");
Console.WriteLine("Введите первое число: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {baseNumber} в степени {power} - это {PowerRec(baseNumber, power)}");