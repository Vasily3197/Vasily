// Напишите программу, которая:
// 1. Принимает на вход число (N). 
// 2. Выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Здравствуйте! Введите, пожалуйста, число, а я выдам Вам таблицу кубов от 1 до Вашего числа");
int CubaLibre = Convert.ToInt32(Console.ReadLine());
Cube(CubaLibre);
void Cube(int CL)
{
    int count = 1;
        while (count <= CL)
        {
        Console.WriteLine($"{CubaLibre} -> {count*count*count}");
        count++;
        }
}