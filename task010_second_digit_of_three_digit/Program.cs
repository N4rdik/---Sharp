/*
10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

using System;
Console.Clear();

System.Console.WriteLine("Please, enter 3-digital number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber>999 || userNumber <100) 
{
    System.Console.WriteLine("Your entered number is not 3-digital");
}
else
{
    int threeDigit = userNumber / 100;
    int twoDigit = userNumber - threeDigit * 100;
    int resultTwoDigit = twoDigit / 10;
    System.Console.WriteLine($"Second digit of your enter number {userNumber} is: {resultTwoDigit}");
}