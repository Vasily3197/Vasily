// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M  до N


void NaturalNumbers(int num1, int num2) 
{
    if (num1 < num2)
    {
        Console.Write($"{num1}, ");
        NaturalNumbers(num1 + 1, num2);
    }

    else if (num2 < num1)
    {
        Console.Write($"{num1}, ");
        NaturalNumbers(num1 - 1, num2);
    }
    else
    {
        Console.WriteLine($"{num1}");  
    }
}

Console.Clear();
Console.WriteLine("Здравствуйте! Введите два натуральных числа, а я выведу все натуральные числа в промежутоке от первого до второго");
Console.Write("Первое число: ");
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(M,N);
