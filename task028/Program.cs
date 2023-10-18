using System;
Console.Clear();

System.Console.WriteLine("Please, enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int multiplier(int a)
{
    int result = 1;
    for (int i = 1; i < a + 1; i++)
    {
        result = result * i;
    }
    if (a < 0 && a % 2 != 0) result = result * -1;
    return result;
}

System.Console.WriteLine($"Factorial of intered number {userNumber}: {multiplier(userNumber)}");