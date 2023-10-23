/*
25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
using System;
Console.Clear();

double Exponentiation (int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
    
    /*int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *=a;
    }
    return result;
    */
} 


int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int userNumber1 = TakeEntNum("Enter a number to exponentiate: ");
int userNumber2 = TakeEntNum("Enter the exponent of the number: ");

System.Console.WriteLine(Exponentiation(userNumber1, userNumber2));