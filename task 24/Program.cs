// Напишите программу, которая:
// 1. Принимает на фход число (А)
// 2. Выдаёт сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Здравствуйте! Введите, пожалуйста, целое положительное число, а я выдам сумму чисел от 1 до Вашего числа");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
    {
        Console.WriteLine("Ой! Какая - то ошибка. Попробуйте сново. Число дожно быть целое и положительное.");
        return;
    }

    int sumNumbers = SumNumbers(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");


    int SumNumbers (int num)
    {
        int sum = 1;
        for(int i = 2; i <= num; i++)
            {
                sum = sum + i;
            }
    return sum;
    } 