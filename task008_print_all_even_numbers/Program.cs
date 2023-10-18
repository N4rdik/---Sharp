using System;
Console.Clear();



System.Console.WriteLine("Введите число ");
int number = System.Convert.ToInt32(System.Console.ReadLine());

for (int i = 2; i < number; i= i + 2)
 System.Console.Write($"{i}, ");

