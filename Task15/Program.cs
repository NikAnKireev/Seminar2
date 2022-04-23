using System;
Console.Clear();

 /* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
 является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число от 1 до 7");
int n=Convert.ToInt32(Console.ReadLine());
// index       0  1  2  3  4  5  6
int[] arrey = {1, 2, 3, 4, 5, 6, 7};
int length = arrey.Length;
string result = (n>=length-1)?$"{n} -> да":$"{n} -> нет";
Console.WriteLine(result);