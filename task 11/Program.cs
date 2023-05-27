// Напишите программу, которая:
// 1. Выводит случайное трёхзначное число 
// 2. Удаляет вторую цифру этого числа
// 456 - 46
// 782 - 72
// 918 - 98

int number = new Random().Next(100,999);
Console.WriteLine($"Случайное число из отрезка от 100 до 999 - это {number}");

int DeleteSecondDigit (int num)
{  
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit * 10+secondDigit;                                                     
}

int deleteSecondDigit = DeleteSecondDigit (number);
Console.WriteLine($"Если убрать из числа {number} вторую цифру, то получится число {deleteSecondDigit}");