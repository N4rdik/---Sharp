using System;
Console.Clear();
System.Console.WriteLine("Введите день недели:");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 || day < 1) Console.WriteLine("Введеное число слишком большое");
// оператор || rpelce word or in if operator statements

if (day == 1)
{
    System.Console.WriteLine("Сегодня понедельник");
}
if (day == 2)
{
    System.Console.WriteLine("Сегодня вторник");
}
if (day == 3)
{
    System.Console.WriteLine("Сегодня среда");
}
if (day == 4)
{
    System.Console.WriteLine("Сегодня четверг");
}
if (day == 5)
{
    System.Console.WriteLine("Сегодня пятница");
}
if (day == 6)
{
    System.Console.WriteLine("Сегодня суббота");
}
if (day == 7)
{
    System.Console.WriteLine("Ура можно выспаться - сегодня Воскресенье");
}




