/*
27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using System;
Console.Clear();


int takeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumOfDigits (int a)
{
    int result = 0;
    for (int i = a; i > 0; i/=10)
    {
        result = result + i%10;
    }
    
    /*
    int digitCount = (int)Math.Log10(a) + 1;
    for (int i = 0; i < digitCount; i++)
    {
        result += a%10;
    }
    */

    return result;
}

int userNumber1 = takeEntNum("Enter number to count sum of all digits in them: ");
System.Console.WriteLine(SumOfDigits(userNumber1));
