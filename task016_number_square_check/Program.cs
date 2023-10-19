/*
16 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/

using System;
Console.Clear();

int userNumber1 = takeEntNum ("Please, enter first number: ");
int userNumber2 = takeEntNum ("Please, enter second number: ");

bool check



int takeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

