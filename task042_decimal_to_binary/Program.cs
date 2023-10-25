/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
using System;
Console.Clear();

string ConvertDecToBin (int a)
{
    string result = "";
    int temp = 0;
    for(int i = a; i > 0.99 ; i/=2)
    {
        if( i % 2 == 0)
        {
            result= "0" + result;
        } 
        else result = "1" + result;
    }
    return result;
}

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userNumber = TakeEnteredNumber("enter number to convert");
string userNumberinBin = ConvertDecToBin(userNumber);
System.Console.WriteLine(userNumberinBin);
