using System;
Console.Clear();

/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. */

Console.WriteLine("Введите первое число");
int first=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int second=Convert.ToInt32(Console.ReadLine());

int work=second*second;


string sum=(first>second&&first==work)?"Является":"Не является";
Console.WriteLine(sum);