/*
64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
using System;
Console.Clear();

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void NaturalNumberPrint (int number)
{
    if (number == 0) return;
    else
        System.Console.Write(number + " ");
        NaturalNumberPrint(number - 1);
}



int userNumber = TakeEnteredNumber("Введите число");

NaturalNumberPrint(userNumber);

