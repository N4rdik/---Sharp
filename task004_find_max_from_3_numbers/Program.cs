using System;
Console.Clear();

System.Console.WriteLine("Please, enter your first number: ");
int firstNumber = System.Convert.ToInt32(System.Console.ReadLine());


System.Console.WriteLine("Please, enter your second number: ");
int secondNumber = System.Convert.ToInt32(System.Console.ReadLine());


System.Console.WriteLine("Please, enter your third number: ");
int thirdNumber = System.Convert.ToInt32(System.Console.ReadLine());

int max = 0;
if (firstNumber > secondNumber) max = firstNumber;
if (thirdNumber > max) max = thirdNumber;


System.Console.WriteLine($"This number {max} is the biggest one from entered.");