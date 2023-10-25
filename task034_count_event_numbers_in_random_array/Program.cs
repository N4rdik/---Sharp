/*
"34. Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
Аргументы, передаваемые в метод/функцию:
'124, 378, 593, 821, 456'
Массив:
124     378     593     821     456 
Количество четных элементов: 3"

*/
using System;
Console.Clear();

int[] GetRandomArray(int start, int end, int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}


int EventNumberCount (int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) result++;
    }
    return result;
}

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
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

int userArraySize = TakeEntNum("Please, enter array size:");
int userArrayStart = TakeEntNum("Please, enter array start number range:");
int userArrayEnd = TakeEntNum("Please, enter array end number range:");

int[] userArray = GetRandomArray(userArrayStart, userArrayEnd, userArraySize);

PrintArray(userArray);

System.Console.WriteLine($"In random array were {EventNumberCount(userArray)} event numbers.");

