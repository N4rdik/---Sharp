/*
21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/
using System;
Console.Clear();


string TakeEntCoordinate(string message)
{
    System.Console.WriteLine(message);
    string result = Convert.ToString(Console.ReadLine());
    return result;
}

double DistanceBetweenPointsIn3D(int[] a, int[] b)
{
    double result = 0;
    for (int i = 0; i < 3; i++)
    {
        result = result + Math.Pow((a[i] - b[i]), 2);
    }
    return result = Math.Sqrt(result);
}

string inputA = TakeEntCoordinate("Enter Coordinate of first point splited by space button (x y z):");
var strings1 = inputA.Split(' ');
int[] pointA = Array.ConvertAll(strings1, s => int.Parse(s));

string inputB = TakeEntCoordinate("Enter Coordinate of first point splited by space button (x y z):");
var strings2 = inputB.Split(' ');
int[] pointB = Array.ConvertAll(strings2, s => int.Parse(s));

System.Console.WriteLine($"Distance beetween of two entered point is: {DistanceBetweenPointsIn3D(pointA, pointB)}");
