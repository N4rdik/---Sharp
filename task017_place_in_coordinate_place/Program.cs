/*
17 Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
using System;
Console.Clear();


string CheckTheQuarter (int[] a)
{
    string result = "";
    if(a[0] > 0 && a[1] > 0) result =  "Your point in first quarter.";
    if(a[0] > 0 && a[1] < 0) result =  "Your point in fourth quarter.";
    if(a[0] < 0 && a[1] > 0) result =  "Your point in third quarter.";
    if(a[0] < 0 && a[1] < 0) result =  "Your point in second quarter.";
    return result;
}

int[] inputA = TakeEntCoordinate("Enter Coordinate of first point splited by space button (x y):");


int[] TakeEntCoordinate(string message)
{
    System.Console.WriteLine(message);
    string coorLine = Convert.ToString(Console.ReadLine());
    var strings1 = coorLine.Split(' ');
    int[] result = Array.ConvertAll(strings1, s => int.Parse(s));
    return result;
}

System.Console.WriteLine(CheckTheQuarter(inputA));