// Напишите программу, которая:
// 1. Принимает на вход число N
// 2. Выдаёт произведение чисел от 1 до N

// 4 -> 24
// 5 -> 120

Console.WriteLine("Здравствуйте! Введите, пожалуйста, целое положительное число, а я выдам произведение чисел от 1 до Вашего числа");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
    {
        Console.WriteLine("Ой! Какая - то ошибка. Попробуйте снова. Число дожно быть целое и положительное.");
        return;
    }

    int factorial = Factorial(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial} ");


    int Factorial (int num)
    {
        int result = 1;
        for(int i = 1; i <= num; i++)
            checked
            {
                result *= i;
            }
    return result;
    } 
    