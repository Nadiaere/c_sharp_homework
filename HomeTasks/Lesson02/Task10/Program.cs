// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
// 456 -> 5    782 -> 8     918 -> 1

Console.Write("Введите трехзначное число n ");
int n = Convert.ToInt32(Console.ReadLine());
string str = n.ToString();
Console.WriteLine(str[1]);


//Console.WriteLine("Вторая цифра числа n - ")

