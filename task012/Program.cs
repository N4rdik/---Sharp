/*
12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.
*/

using System;
Console.Clear();

System.Console.WriteLine("Pleasee, enter your first number: ");
int user1Number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Please, enter your second number: ");
int user2Number = Convert.ToInt32(Console.ReadLine());

if (user2Number % user1Number == 0) System.Console.WriteLine($"The second number {user2Number} is divisible with {user1Number} without remainder {user2Number / user1Number} times");
else
{
    System.Console.WriteLine($"Your second number {user2Number} can not be diveded with first number {user1Number}. Remainder will be: {user2Number % user1Number}");
}