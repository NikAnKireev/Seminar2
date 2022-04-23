using System;
Console.Clear();

/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное число");
int N=int.Parse(Console.ReadLine());
string numS=N.ToString();
int result = Convert.ToInt32(numS[1].ToString());
Console.WriteLine($"{N} -> {result}");