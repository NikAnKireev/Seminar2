using System;
Console.Clear();

/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. */

Console.WriteLine("Введите первое число");
int first=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int second=Convert.ToInt32(Console.ReadLine());
string sum=(first==second*second)?$"{first} Является квадратом {second}":(second==first*first) 
?$"{second} Является квадратом {first}":"Не является";
Console.WriteLine(sum);