// Напишите программу, которая:
// 1. Принимает на вход координаты двух точек.
// 2. Находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
    {
        double sumCat = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1);
        double d = Math.Sqrt(sumCat);
        return d;
    }

Console.WriteLine("Здравствуйте! Введите, пожалуйста, координаты двух точек, а я найду расстояние между ними в в 3D пространстве.");

Console.Write("xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("yA: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("zA: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("yB: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("zB: ");
int zB = Convert.ToInt32(Console.ReadLine());

double result = Distance(xA, yA, zA, xB, yB, zB);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(result);

