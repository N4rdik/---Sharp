/*
"Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8"
*/
using System;
Console.Clear();


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string FebonchiNumber(int a)
{
    string result = "0 1";
    int summ = 0;
    if(a == 0) result = result + "0";
    if(a == 1) result = result + "0 1";
    else
    {
        for (int i = 2; i <= a; i++)
        {
            result = result + (i-1) + (i-2);    
        }
    }
    return result;

}

int userNumber = TakeEnteredNumber("Enter number: ");


System.Console.WriteLine(FebonchiNumber(userNumber));
