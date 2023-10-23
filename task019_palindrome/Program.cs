/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

using System;
Console.Clear();

bool IsPalindrome(int number)
{
    int digitCount = (int)Math.Log10(number) + 1;
    if (digitCount !=5) Console.WriteLine("Число не пятизначное");
    int diveder = 10000;
    for (int i = 1; i < 2; i++)
    {
        if (number/diveder != number%10) return false;
        number /= 10;
        diveder /=10;
    }
    return true;
}


int TakeUserNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int userNumber = TakeUserNumber("Enter the 5 digits number to check if it is palindrom: ");
bool result = IsPalindrome(userNumber);
System.Console.WriteLine($"{result}");
