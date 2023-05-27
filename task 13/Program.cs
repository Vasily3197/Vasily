// Напишите программу, которая:
// Выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num (string message)
{
Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

int third (int number)
{
    while (number>999)
    {
        number /=10;
    }
    return number %10;
}

bool VaslidateNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine("Кажется, Здесь нет третей цифры");
        return false;
    }
    return true;
}

int number = num ("Здравствуйте! Введите, пожалуйста трёхзначное число, а я покажу его третью цифру");

if (VaslidateNumber(number))
{   
    Console.WriteLine ($"Последняя цифра Вашего числа - {third (number)}");
}