﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//           является ли число чётным (делится ли оно на два без остатка).

// Дано
// 4 -> да
//  -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int remDiv = N % 2;              // remDiv - остаток от деления, (%) деление без остатка

if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
 // end