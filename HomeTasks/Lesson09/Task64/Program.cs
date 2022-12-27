// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"N={N}");
if (N > 1)
for (int i = 1; i <= N; i++)
    Console.Write($" {i}");
else
    for (int i = N; i <= N; i++)
        Console.Write($" {i}");

System.Console.WriteLine();

