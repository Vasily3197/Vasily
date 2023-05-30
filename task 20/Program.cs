// Напишите программу, которая: 
// 1. На вход принимает координаты двух точек. 
// 2. Находит расстояние между ними в 2D пространстве. 
// А(3,6); В(2,1) -> 5,09
// A(7,5); B(1, -1) -> 7,21


// double d = Math.Sqrt(5);
// double num = 5,0998
// double dRound = Math.Round(d,2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRound);


double Distance(int x1, int y1, int x2, int y2)
    {
        double sumCat = (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
        double d = Math.Sqrt(sumCat);
        return d;
    }

Console.WriteLine("Здравствуйте! Введите, пожалуйста, координаты двух точек, а я найду расстояние между ними в в 2D пространстве.");

Console.Write("xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("yA: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("yB: ");
int yB = Convert.ToInt32(Console.ReadLine());
double result = Distance(xA, yA, xB, yB);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(result);
