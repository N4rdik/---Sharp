using System;
Console.Clear();

System.Console.WriteLine("Введите число ");
int number = System.Convert.ToInt32(System.Console.ReadLine());


if (number % 2 == 0)
     {
       System.Console.WriteLine($"Число `{number}` чётное");
     }
      else
      {
        System.Console.WriteLine($"Число `{number}` нечётное");
      }
