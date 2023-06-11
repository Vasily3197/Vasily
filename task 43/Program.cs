//Напишите программу, которая: 
// 1. Найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumber(string prompt)
{
    Console.Write($"Введите {prompt} значение: ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

void GetintersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Линии пересекаются");
            return;
        }
        
        Console.WriteLine("Линии Параллельны");
        return;
    }

    double x = Math.Round((b2 - b1) / (k1 - k2), 3); // formula for x is (b2 - b1) / (k1 - k2)
    double y = Math.Round(k1 * x + b1, 3); // formula for y is k1 * x + b1
    Console.WriteLine($"Точки пересечения -  ({x}, {y})");
}

double k1 = GetNumber("k1");
double b1 = GetNumber("b1");
double k2 = GetNumber("k2");
double b2 = GetNumber("b2");

GetintersectionPoint(k1, b1, k2, b2);
