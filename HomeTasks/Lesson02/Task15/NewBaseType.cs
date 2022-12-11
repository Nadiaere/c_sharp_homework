// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


NewMethod();

static void NewMethod()
{
    Console.Write("Введи цифру, обозначающую день недели: ");
    int day = Convert.ToInt32(Console.ReadLine());

    void CheckingTheDayOfTheWeek(int day)
    {
        if (day == 6 || day == 7)
        {
            Console.WriteLine("Явлется ли этот день выходным? - да");
        }
        else Console.WriteLine("Является ли это день выходным? - нет");
    }

    CheckingTheDayOfTheWeek(day);
}
