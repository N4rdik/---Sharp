/*
"Задача 39: Напишите программу, которая перевернёт одномерный
массив (последний элемент будет на первом месте, а первый - на
последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]"
*/
using System;
Console.Clear();


int[] ReverseArray (int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[array.Length - i -1] = array[i];
    } 
    return result;
}

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] randomArray(int start, int end, int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

int userArraySize = TakeEntNum("Please, enter array size:");
int userArrayStart = TakeEntNum("Please, enter array start number range:");
int userArrayEnd = TakeEntNum("Please, enter array end number range:");

int[] userArray = randomArray(userArrayStart, userArrayEnd, userArraySize);
int[] userRevArray = ReverseArray(userArray);

PrintArray(userArray);
PrintArray(userRevArray);
