﻿/*
35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении 
сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

using System;
Console.Clear();

int[] GetRandomArray(int start, int end, int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int FindNumbersInRange (int[] array, int start, int end)
{
    int count = 0;    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= start && array[i] <= end) count++;
    }
    return count;
}

int userArraySize = TakeEntNum ("Please, enter array size:");
int userArrayStart = TakeEntNum ("Please, enter array start number range:");
int userArrayEnd =  TakeEntNum ("Please, enter array end number range:");

int[] userArray = GetRandomArray (userArrayStart, userArrayEnd, userArraySize);
PrintArray (userArray);

int userRangeStartFind = TakeEntNum("Enter the start of range to find numbers in given Array: ");
int userRangeEndFind = TakeEntNum ("Enter the end of range to find numbers in given Array: ");
int  userRangeCountInArray = FindNumbersInRange(userArray, userRangeStartFind, userRangeEndFind);
System.Console.WriteLine($"Counted numbers in given range in curent array: {FindNumbersInRange(userArray, userRangeStartFind, userRangeEndFind)}. ");
 
