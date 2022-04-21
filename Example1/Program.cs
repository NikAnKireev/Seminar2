using System;
Console.Clear();

/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

456 -> 46

782 -> 72

918 -> 98 */ 

int num = new Random().Next(100,1000);
string numS=num.ToString();
int a1 = Convert.ToInt32(numS[0].ToString());
int a2 = Convert.ToInt32(numS[2].ToString());

Console.WriteLine($"{num}->{a1}{a2}");
