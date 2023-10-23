/*
18 Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
using System;
Console.Clear();

string CheckTheQuarterPointRange (int a)
{
    string result = "";
    if(a == 1) result =  "To place your point in first quarter coordinates should be x > 0 and y > 0.";
    if(a == 2) result =  "To place your point in second quarter coordinates should be x > 0 and y < 0.";
    if(a == 3) result =  "To place your point in third quarter coordinates should be x < 0 and y > 0.";
    if(a == 4) result =  "To place your point in fourth quarter coordinates should be x < 0 and y < 0.";
    return result;
}
System.Console.WriteLine("Give quarter number to know point coordinate range");
int inputA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(CheckTheQuarterPointRange(inputA));