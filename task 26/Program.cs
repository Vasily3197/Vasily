// Напишите программу, которая:
// 1. Принимает на вход число 
// 2. Выдаёт количество цифр в числе 
// 456   -> 3
// 78    -> 2
// 89126 -> 5


int DigitsInNumber(int num)
{
    int digits = 0;

    if (num == 0) return 1;
        while (num !=0 )
        {
            digits++;
            num /= 10;
        }
    return digits;
} 

Console.WriteLine("Здравствуйте! Введите, пожалуйста, целое положительное число, а я скажу Вам сколько в нём цифр");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"В числе {number} {DigitsInNumber(number)} цифры");