﻿/*Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

/*
using System;
Console.Clear();


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

bool CheckPosition(int row, int column, int[,] array)
{
    if (row < array.GetLength(0) && column < array.GetLength(1)) return true;
    else return false;
}

int FindIndex(int row, int column, int[,] array)
{
    int result = 0;
    if (CheckPosition(row, column, array) == true)
    {
       return result = array [row, column];
    }
    else false;
}

void PtintNumberFromIndex


int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnteredNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);
System.Console.WriteLine(FindIndex(TakeEnteredNumber("Введите строку для нахождения значения в матрице:"), TakeEnteredNumber("Введите строку для нахождения значения в матрице: "), user2DArray));
*/

using System;
Console.Clear();

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetIndex2DArray(int row, int column, int k)
{
    int[,] array = new int[row, column];
    int num = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = num;
            num = num + k;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int numberK = TakeEnteredNumber("What number to encrese5? ");
int[,] user2DIndexArray = GetIndex2DArray(userArrayRow, userArrayColumn, numberK);

Print2DArray(user2DIndexArray);
int PositionX = TakeEnteredNumber("Which row to find: ");
int PositionY = TakeEnteredNumber("Which column to find: ");

void FindElemnetInArray(int[,] array, int x, int y)
{
    if(x < array.GetLength(0) + 1 && y < array.GetLength(1) + 1)
    System.Console.WriteLine($"Такое число в массиве есть, это число {array[x, y]}");
    else
    System.Console.WriteLine("Такого числа в массиве нет!");
}

FindElemnetInArray(user2DIndexArray, PositionX, PositionY);

/*
using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
      for (int i = 0; i < matrix.GetLength(0); i++)
        {
        for (int j = 0; j < matrix.GetLength(1); j++)
          {
            System.Console.Write(matrix[i, j] + "\t");
          }
        System.Console.WriteLine();
        }
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
    int[,] array = new int[n, m];
    int result = 1;
    for(int i = 0; i < n; i++)
    {
      for(int j = 0; j < m; j ++)
      {
        array[i,j] = result;
        result +=k;
      }
    }
    return array;

    }
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже
    int[] result = {0,0};
    if(rowPosition >= matrix.GetLength (0) || columnPosition >= matrix.GetLength (1)) return result;
    else 
    {
      result [0] = matrix[rowPosition, columnPosition];
      return result;        
    }
    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
    if(results[0] > 0)
    {
      Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    }
    else
    {
      Console.WriteLine($"There is no such index");
    }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}
*/