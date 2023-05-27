// Напишите программу, которая:
// 1. На вход принимает число
// 2. Проверяет, кратно ли оно одновременно 7 и 23 
// 14 - нет
// 46 - нет
// 161 - Да    

bool DevidedByTwoNumbers(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}

Console.WriteLine("Введите, пожалуйста, целое число, а я скажу кратно ли оно одновременно 7 и 23");
int number = Convert.ToInt32(Console.ReadLine());

bool myResult = DevidedByTwoNumbers(number, 7,23);
Console.WriteLine(myResult ? "Да, это число кратно одновременно 7 и 23" : "Нет, это число не кратно одновременно 7 и 23");