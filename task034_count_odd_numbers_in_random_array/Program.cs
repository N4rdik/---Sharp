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

int[] GetRandomArray(int[] array)
{
    int[] arr = new int[array[2]];
    for (int i = 0; i < array[2]; i++)
    {
        arr[i] = new Random().Next(array[0], array [1] +1);
    }
    return arr;
}

int OddNumberCount (int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) result++;
    }
    return result;
}

int[] TakeMoreNumber(string message)
{
    System.Console.WriteLine(message);
    string coorLine = Convert.ToString(Console.ReadLine());
    var strings1 = coorLine.Split(' ');
    int[] result = Array.ConvertAll(strings1, s => int.Parse(s));
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

int[] userArrayParametrs = TakeMoreNumber("Enter begin, end of range and size of your array splited by space button: ");
int[] userArray = GetRandomArray(userArrayParametrs);

PrintArray(userArray);

System.Console.WriteLine($"In random array were {OddNumberCount(userArray)} odd numbers.");
