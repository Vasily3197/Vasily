// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите два неотрицательных числа");
Console.Write("Первое число: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Второе число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
if (m > 0 && n > 0 )
{
    int function = Ack(m, n); 
    int Ack (int n, int m)
    {
        if (n == 0)
        return m + 1;
        if (m == 0)
        return Ack (n - 1, 1);
        return Ack(n - 1, Ack(n, m - 1));
    }
    Console.WriteLine($" m = {m}, n = {n} -> A(m,n) = {function} ");
}
else 
{
Console.WriteLine ("Какая - то ошибка. Возможно, введённые  числа отрицательные или равны нулю.");
}