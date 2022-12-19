// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int [,] GreateArray (int row, int column)
{
    return new int[row, column];
}

void FillArray (int [,] Array)
{
    for (int row = 0; row < Array.GetLength(0); row++)
    {
        int min = 0;  // подумать как ввести числа с консоли
        int max = 20;
        for (int column = 0; column < Array.GetLength(1); column++)
        {
            Array [row, column] = new Random().Next(min, max);
        }
    }
}
 
void PrintArray (int [,] Array)
{
    for (int row = 0; row < Array.GetLength(0); row++)
    {
        for (int column = 0; column < Array.GetLength(1); column++)
        {
            Console.Write($"{Array[row, column], 4}");
        }
        System.Console.WriteLine();
    }
}

void OrderArray (int [,] Array)
{
    for (int row = 0; row < Array.GetLength(0); row++)
    {
        for (int column = 0; column < Array.GetLength(1); column++)
        {
           for (int i = 0; i < Array.GetLength(1) - 1; i++)
           {
             if (Array[row, i] < Array[row, i + 1])
             {
                int temp = Array[row, i + 1];
                Array[row, i + 1] = Array [row, i];
                Array[row, i] = temp;
             }
           }
        }
    }
}
 
// вывод

Console.WriteLine("\n Задайте двумерный массив: ");

int [,] matrix = GreateArray (3,4);
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("\n Упорядоченные по убыванию элементы массива: ");
OrderArray(matrix);
PrintArray(matrix);



// public class Example  метод сортировки массива по убыванию
// {
//     public static void Main()
//     {
//         int[] array = new int[] { 5, 7, 2, 3, 9 };
 
//         int[] reversedSorted = array.OrderByDescending(x => x).ToArray();
 
//         Console.WriteLine(String.Join(", ", reversedSorted));        // 9, 7, 5, 3, 2
//     }
// }