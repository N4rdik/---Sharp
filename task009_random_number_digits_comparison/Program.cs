/*
09 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/
using System;
Console.Clear();

int randomNum = new Random().Next(10, 99);

int firstDigit = randomNum / 10;
int secondDigit = randomNum % 10;

if (firstDigit > secondDigit) System.Console.WriteLine($"First digit {firstDigit} is bigger than second digit {secondDigit} of generated random number {randomNum}");
else
{
    System.Console.WriteLine($"Second digit {secondDigit} is bigger than first digit {firstDigit} of generated random number {randomNum}");
}