// Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int i=1, res=1;
Console.WriteLine("Введите чило a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чило b ");
int b = Convert.ToInt32(Console.ReadLine());
while (i<=b)
    {
        res=res*a;
        i++;
    }
Console.WriteLine("Ответ a ^ b = " + res);
