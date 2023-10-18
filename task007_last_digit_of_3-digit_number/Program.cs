using System;
Console.Clear();

System.Console.WriteLine("Enter 3-digit number ");
int user_number = System.Convert.ToInt32(System.Console.ReadLine());

int result = user_number % 10 ;

System.Console.WriteLine($"Last digit of your 3-digit number is: {result}");
