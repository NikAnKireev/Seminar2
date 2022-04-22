using System;
Console.Clear();

/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да */

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
string answer=(num%7==00 && num%23==00)?$"{num} -> да":$"{num} -> нет";
Console.WriteLine(answer);