/*
14 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
*/

using System;
Console.Clear();


int takeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNumber = takeEntNum ("Please, enter the number: ");

if (userNumber%7 == 0 && userNumber%23 == 0)
{
    System.Console.WriteLine($"Your given number {userNumber} is devidable on 7 и 23");
}
else
{
    System.Console.WriteLine($"Your given number {userNumber} is not devidable on 7 и 23");
}
