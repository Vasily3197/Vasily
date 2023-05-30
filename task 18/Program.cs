// Напишите программу, которая:
// 1. Принимает на вход номер плоскости четверти
// 2. Показывает возможные координаты точки 

Console.WriteLine("Введите, пожалуйста, номер плоскости, а я покажу возможные координаты");
string quarter = Console.ReadLine();

string range = Range(quarter);
string result = range == null
                ? "Я не знаю такой четверти. Попробуйте, пожалуйста, снова."
                : "Вот возможный диапазон координат для указанной четверти:"
                + $"{range}";

Console.WriteLine(result);

string Range (string q)
{
    if (q == "1") return "x > 0, y > 0";
    if (q == "2") return "x < 0, y > 0";        
    if (q == "3") return "x < 0, y < 0";        
    if (q == "4") return "x > 0, y < 0";       
    return null; 
}

