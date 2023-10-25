/*
"Задача 45: Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования"
*/

int[] CopyArray (int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
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

