/*
13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

using System;
Console.Clear();

System.Console.WriteLine("Please, enter your number:");
int userNumber = Convert.ToInt32(Console.ReadLine());


int digit3(int a)
{
    int result = 0;
    for (int i = 1; i = 4; i++)
    {
        a = a / 10;
    }
    result = a % 10;
    return result;
}
if ((userNumber / 100) > 0)
{
    System.Console.WriteLine($"Third digit of your entered number {userNumber} is: {digit3(userNumber)}");
}
else
{
    System.Console.WriteLine($"Your number is not contain third digit.");
}
