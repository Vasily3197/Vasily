// Напишите программу, которая:

// 1. На вход принимает два числа
// 2. Проверяет проверяет, является ли одно число квадратом другого 

// 5 и 25 - Да
// -4 и 16 - Да
// 25 и 5 Да
// 8 и 9 Нет

bool SquareTwo(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1*num1; // || - это оператор или
}

Console.WriteLine("Введите, пожалуйста, целое число, а я скажу является ли оно квадратом второго, введенного Вами числа");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите, пожалуйста, второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

bool squareTwo = SquareTwo(number1, number2);
Console.WriteLine(squareTwo ? "Да, это число является квадратом второго" : "Нет, это число не является квадратом второго");