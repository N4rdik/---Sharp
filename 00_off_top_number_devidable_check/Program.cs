/*
16 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/

using System;
Console.Clear();


int takeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNumber1 = takeEntNum ("Please, enter first number: ");
int userNumber2 = takeEntNum ("Please, enter second number: ");


if (userNumber1%userNumber2 == 0) System.Console.WriteLine($"Your first number `{userNumber1}` could be devided with second number `{userNumber2}` `{userNumber1/userNumber2}` times");
if (userNumber2%userNumber1 == 0) System.Console.WriteLine($"Your second number `{userNumber2}` could be devided with first number `{userNumber1}` `{userNumber2/userNumber1}` times");
if (userNumber1%userNumber2 != 0 || userNumber2%userNumber1 != 0)
{
    System.Console.WriteLine("Given numbers are not devidable with each other");
}