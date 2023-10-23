﻿/*
22 Напишите программу, которая принимает на вход число(N) и выдаёт таблицу квадратов чисел от 1 до N.
*/
using System;
Console.Clear();

void PrintSquareNumber(int a)
{
    for (int i = 1; i <= a; i++)
    {
        System.Console.WriteLine($"{i} * {i} = {Math.Pow(i,2)}");
    }
    }

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNumber1 = TakeEntNum("Enter number for calculation: ");

PrintSquareNumber(userNumber1);