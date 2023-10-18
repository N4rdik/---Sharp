/*
Задача 1. Напишите программу, которая на входи принимет число и выдает его квадрат (число умноженное само на себя)
*/

System.Console.Clear();

System.Console.WriteLine("Please give a number: ");

// Quick call for writeline - cw

int userNumber = System.Convert.ToInt32(System.Console.ReadLine());
/*
при именование новой переменной обязательно указать ее тип 
int - целое число в 32 разряда
double - не целое число
string - строчка
*/
// ask user for his variable number                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             

int result = userNumber * userNumber;

System.Console.WriteLine($"The square of the number {userNumber} is {result}.");
//значок доллера в терминале вывода позволяет представить в строчном виде инфу с переменными
// переменные для правильного отображение в окне должны быть прописаны через фигурные скобки



