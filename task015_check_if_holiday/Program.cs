/*
15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

using System;
Console.Clear();


int takeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNumber = takeEntNum("Please, enter the number of the week day: ");

if (userNumber < 1 || userNumber > 7) System.Console.WriteLine("Error! Such a day doesn't exist in a week! Please, enter the valid number of the week day (from 1 to 7):");
else
{
    if (userNumber > 5) System.Console.WriteLine("Congrats! Today is holiday!");
    if (userNumber < 6) System.Console.WriteLine("Bad day to wake up because you need to work!");
}
