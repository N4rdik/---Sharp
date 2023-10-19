/*
13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

using System;
Console.Clear();

System.Console.WriteLine("Please, enter your number:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = digit3(userNumber);
if (userNumber < 100) 
{
    System.Console.WriteLine($"Your number is not contain third digit.");
}
else
{
    System.Console.WriteLine($"Third digit of your entered number {userNumber} is: {result}");
}

int digit3(int a)
{
    if (a < 0) a = a*-1;
    a=a/10/10%10;
    int result = a;
    return result;
}


    
