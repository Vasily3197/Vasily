// Задайте значения M и N. 
// Напишите программу, которая 
// Найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.WriteLine("Введите два натуральных числа, а я найду сумму чисел в промежутке от первого до второго");
Console.Write("Первое число: ");
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Второе число: ");
int N = Convert.ToInt32(Console.ReadLine()); 

if (M >= 0 && N >= 0 ) 
{

    int SumNum(int m, int n)
    {
        if (m == n)
        return m;

        if (n < m)
        return n + SumNum(m, n + 1);

        else
        return m + SumNum(m + 1, n);
    }   
    Console.WriteLine($"Сумма чисел в промежутке от {M} до {N} равна {M + SumNum(M + 1, N)}");
    SumNum(M,N); 
}
else 
{
Console.WriteLine ("Какая - то ошибка. Возможно, введённые  числа не являются натуральными.");
}

