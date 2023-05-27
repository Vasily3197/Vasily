// Напишите программу, которая: 
// 1. Выводит случайное число из отрезка [10, 99] 
// 2. Показывает наибольшую цифру числа

// ОБЫЧНОЕ РЕШЕНИЕ

// int number = new Random().Next(10,99); //Если в скобках после nex указать 100, то покажет все рандомные числа от 0 до 99 включительно.
// Console.WriteLine($"Случайное число из отрезка от 10 до 99 - это {number}");
// int firstDigit = number / 10; 
// int secondDigit = number % 10;
//     if (firstDigit>secondDigit) Console.WriteLine($"Наибольшая цифра числа - это {firstDigit}");
//         else 
//             Console.WriteLine($"Наибольшая цифра числа - это {secondDigit}");

// // Тернарный (тройной) оператор - аналог условного оператора с особенностями. 

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // в переменную вводим результат. Если сохранятеся, то после знака вопроса secondDigit, иначе, после двоеточия -  secondDigit
// Console.WriteLine($"Наибольшая цифра числа - это {maxDigit}");

// РЕШЕНИЕ ЧЕРЕЗ ФУНКЦИЮ

int number = new Random().Next(10,99);
Console.WriteLine($"Случайное число из отрезка от 10 до 99 - это {number}");
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа - это {maxDigit}");

int MaxDigit(int num) // другие обозначения используются для разной видимости num = nember             ВХОД
{  
    int firstDigit = num / 10;                                                                         // АЛ
    int secondDigit = num % 10;                                                                        // ГО
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;                                // РИТМ
    return maxDigit;                                                                                   // ВЫХОД
}
 

