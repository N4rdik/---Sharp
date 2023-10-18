using System;
Console.Clear();

System.Console.WriteLine("Please, enter your first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Please, enter your second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber) System.Console.WriteLine($"Your first number {firstNumber} is bigger than second number {secondNumber}");
if (firstNumber < secondNumber) System.Console.WriteLine($"Your first number {firstNumber} is less than second number {secondNumber}");
if (firstNumber == secondNumber) System.Console.WriteLine($"Your intered numbers {firstNumber} are equal.");

