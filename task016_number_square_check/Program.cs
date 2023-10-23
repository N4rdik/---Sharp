/*
16 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int userNumber1 = TakeEntNum("Please, enter first number: ");
int userNumber2 = TakeEntNum("Please, enter second number: ");

bool CheckSquare(int a, int b)
{
    if (Math.Pow(a, 2) == b || Math.Pow (b, 2) == a) return true;
    else return false;
}

System.Console.WriteLine(CheckSquare(userNumber1, userNumber2));

