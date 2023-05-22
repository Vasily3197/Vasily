// Напишите программу, которая: 
// Будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Здравствуйте! Введите, пожалуйста, цифру, а я скажу, какой это день недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Это же понедельник! По мнению многих - cамый тяжёлый день");
}

if (number == 2)
{
    Console.WriteLine("Это же вторник! Второй по счёту день недели");
}
if (number == 3)
{
   Console.WriteLine("Среда - середина недели!");
}
if (number == 4)
{
    Console.WriteLine("Четверг. После него, кажется, пятница");
}
if (number == 5)
{
    Console.WriteLine("Урааа! Пятница");
}
if (number == 6)
{
    Console.WriteLine("Суббота!");
}
if (number == 7)
{
    Console.WriteLine("Конец недели - Воскресенье!");
}
if (number > 1 && number < 7)
{
}

else
{ 
    Console.WriteLine("В неделе всего семь дней. Введите, пожалуйста, число от 1 до 7");
}
