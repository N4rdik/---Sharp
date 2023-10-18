/*
29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] 
*/

using System;
Console.Clear();

System.Console.WriteLine("Please, enter the start number of array range:");
int arrStart = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Please, enter the end number of array range:");
int arrEnd = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Please, enter the lenght  of array:");
int arrLenght = Convert.ToInt32(Console.ReadLine());


int[] randomArray(int start, int end, int lenght)
{
    int[] array = new int[size];
    for (int i = 0; i < sizeof; i++)
    {
        array[i] = new Random().Next(start, end, lenght);
    }
    return array;
}

void printArray
{
    System.Console.WriteLine("[");
    for (int i = 0; i < arr.length; i++)
    {
        System.Console.WriteLine(arrEnd[i]);
        if (int < arr.lenght - 1)
            System.Console.WriteLine(", ");
    }
    System.Console.WriteLine("]");
}

int[] userArray = randomArray(arrStart, arrEnd, arrLenght);

printArray(userArray);
