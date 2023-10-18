/*
10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

using System;
Console.Clear();

System.Console.WriteLine("Please, enter 3-digit number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int threeDigit = userNumber / 100;
int twoDigit = userNumber - threeDigit * 100;
int resultTwoDigit = twoDigit / 10;


System.Console.WriteLine($"Second digit of your enter number {userNumber} is: {resultTwoDigit}");