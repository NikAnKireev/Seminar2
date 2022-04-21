using System;
Console.Clear();

/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());

if (x%y==0)
{
    Console.WriteLine($"{x}, {y}-> кратно");
}
else
{
    Console.WriteLine($"{x}, {y} -> не кратно, остаток {x/y}");
}