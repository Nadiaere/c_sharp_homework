// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string text)
{
    Console.Write(text);
    int value = int.Parse(Console.ReadLine());
    return value;
}
int SumNumber(int N)
{
    int d, sum = 0;
    while (N != 0)
    {
        d = N % 10;
        sum = sum + d;
        N = N / 10;
    }
    return sum;
}
string a = "Введите число: ";
int b = GetNumber(a);
int result = SumNumber(b);
Console.WriteLine("Сумма цифр в числе = " + result);




// int GetNumber()      упрощеный вариант
// {
// Console.Write("Введите число: ");
// int value = int.Parse(Console.ReadLine());
// или int number = Convert.ToInt32(Console.ReadLine());
// return value;
// }

// Convert.ToInt32() (преобразует к типу int)

// Convert.ToDouble() (преобразует к типу double)

// Convert.ToDecimal() (преобразует к типу decimal)