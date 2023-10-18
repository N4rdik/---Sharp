/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
using System;
Console.Clear();

System.Console.WriteLine("Please, enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Sum(int a)
{
    int result = 0;
    for ( int i=1; i < a+1; i++)
    {
        result = result + i;
    }
    return result;
}

System.Console.WriteLine($"Sum of all natural numbers from 1 to your entered number {userNumber} is: {Sum(userNumber)}");