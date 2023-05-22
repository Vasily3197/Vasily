// Демонстрация решения.
// Напишите программу, которая:

// 1. На вход принимает число 
// 2. Выдаёт его за квадрат (число, умноженное на само себя).

// Например:
//  4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine()); // Команда Convert.ToInt32 преобразует строку в число
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");



