/*
11 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
*/

using System;
Console.Clear();

int randomNumber = new Random().Next(100, 999);

int thirdDigit = randomNumber / 100;
int secondDigit = (randomNumber - (thirdDigit * 100)) / 10;
int firstDigit = (randomNumber -(thirdDigit*100)- (secondDigit*10));

string twoDigitNumber = ($"{thirdDigit}{firstDigit}");
System.Console.WriteLine($"Random number is {randomNumber}, new number without second digit will be: {twoDigitNumber}");