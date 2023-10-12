/*
Задача 1. Проверить два введенных числа - квадрат ли это?
*/
using System;

Console.Clear();

System.Console.WriteLine("Ведите первое число: ");
int userNumber1 = System.Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int userNumber2 = System.Convert.ToInt32(Console.ReadLine());

if (userNumber1 / userNumber2 == userNumber2)
{
    System.Console.WriteLine($"Введеное первое число являеться квадратом второго.");
}
else
{
    if (userNumber2 / userNumber1 == userNumber1) System.Console.WriteLine($"Введеное второе число являеться квадратом первого.");
    else System.Console.WriteLine($"Введеное первое число не являеться квадратом второго и наоборот.");
    
}

