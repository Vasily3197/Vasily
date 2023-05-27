// Напишите программу, которая:
// 1. Будет принимать на вход 2 числа.
// 2. Выводить является ли первое число кратным второму. 
// 3. Если нет, то выводит остаток от деления. 

// 35 и 5 - не кратно, осток 4
// 16 и 4 - кратно


Console.WriteLine("Введите, пожалуйста, целое число А, а я скажу Вам, кратно ли оно числу B. Если не кратно, то я выведу остаток от деления");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Теперь, введите целое число B");
int num2  = Convert.ToInt32(Console.ReadLine());

int result = Remain(num1, num2);
string printLine = result == 0 ? $"Да, число {num1} кратно числу {num2}" : $"Нет,число {num1} не кратно {num2}, остаток {result}";
Console.WriteLine(printLine);

int Remain(int number1, int number2)
{
    int res = number1 % number2;

    return res;
}