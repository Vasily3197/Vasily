// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.Clear();

int SumDigitsRec(int num, int sum = 0)
{
    if (num == 0) return sum;
    else return sum + SumDigitsRec(num / 10, num % 10);
}

int SumDigitsRec1(int n)
{
    if (n == 0) return 0;
    else return n % 10 + SumDigitsRec1(n / 10);
}

Console.Write("Введите, пожалуйста, число, а я выведуу сумму цифр, из которых оно состоит: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigitsRec1(number));


