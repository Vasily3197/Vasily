// Напишите программу, которая: 
// 1. Принимает на вход цифру, обозначающую день недели.
// 2. Проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Promt (string message)

{
Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

bool IsWeek(int WeekDay) 
{
    if (WeekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekDay (int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int WeekDay = Promt("Введите, пожалуйста, день недели, а я скажу, выходной это, или нет");
if (ValidateWeekDay (WeekDay))
{
    if (IsWeek(WeekDay))

    {
        Console.WriteLine("Это выходной");
    }
    else
    {
        Console.WriteLine("Нет, это рабочий день");
    }
}