/*

26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

using System;
Console.Clear();

System.Console.WriteLine("Please, enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int numDg (int a)
    {
        if (userNumber)
        int count = 0;
        for (int i = 1; i < userNumber; i = i * 10)
            {
                count = count + 1;

            }
        return count;
    }
System.Console.WriteLine($"Number of digits in your entered number {userNumber}: {numDg(userNumber)}");