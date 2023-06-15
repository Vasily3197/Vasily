// Напишите задачу, которая:
// 1. Принимает на вход три числа.
// 2. Проверяет, может ли существовать треугольник со сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других его сторон.

bool Triangle (int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num3 + num1 && num3 < num1 + num2;
}

Console.WriteLine("Здравствуйте! Введите, пожалуйста, три числа, а я скажу может ли существовать треугольник со сторонами такой длины или нет.");
Console.Write("A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("C: ");
int C = Convert.ToInt32(Console.ReadLine());

bool triangle = Triangle(A,B,C);
Console.WriteLine(triangle ? "Да, такой треугольник может существовать" : "Нет, такой треугольник существовать не может");