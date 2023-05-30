// Напишите программу, которая:
// 1. Принимает на входкоординаты точки (X и Y), которые не равны нулю
// 2. Выдаёт номер четверти плоскости , в которой находится эта точка. 


Console.WriteLine("Введите, пожалуйста, координаты точки, а я покажу номер четверти плоскости, где находится заданная Вами точка");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int qarter = Qarter(xCoordinate, yCoordinate);
string result = qarter > 0 
                ? $"Координаты заданной Вами точки находятся в четверти {qarter}"
                : "Ой, я не знаю такие координаты. Попробуйте, пожалуйста, снова.";
Console.WriteLine(result);

int Qarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;        
    if (x < 0 && y < 0) return 3;        
    if (x > 0 && y < 0) return 4;       
    return 0; 
}

 