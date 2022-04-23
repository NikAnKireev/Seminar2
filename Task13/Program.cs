using System;
Console.Clear();

/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.WriteLine("Введите число");
int N=Convert.ToInt32(Console.ReadLine());
/*string numS=N.ToString();
int length = numS.Length;
string result=(length>=3)?$"{N} -> {numS[2]}":$"{N} -> третьей цифры нет "; */

string result = (N>99)?$"{N} -> {N.ToString()[2]}":(N<-99)?$"{N} -> {N.ToString()[3]}":$"{N} -> нет третьей цифры";
Console.WriteLine(result);