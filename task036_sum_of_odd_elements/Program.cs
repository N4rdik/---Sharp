﻿using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
        // Введите свое решение ниже
        int result = 0;
        for (int i = 1; i < array.Length; i ++)
        {
            if(i%2 !=0) result = result + array[i];
        }
        return result;
    }

    public static void PrintArray(int[] array)
    {
        // Введите свое решение ниже
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i< array.Length - 1) Console.Write("\t");
    }
    System.Console.WriteLine("");
    }


    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 18, 76, 11 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}