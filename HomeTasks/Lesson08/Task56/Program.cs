// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int [,] GreateArray (int row, int column)
{
    return new int[row, column];
}

void FillArray (int [,] Array)
{
    for (int row = 0; row < Array.GetLength(0); row++)
    {
        for (int column = 0; column < Array.GetLength(1); column++)
        {
            Array [row, column] = new Random().Next(1,100);
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

int SumStringArray (int [,] Array)
{
    int minRowSum = int.MaxValue, indexMinRow = 0;

        for (int i = 0; i < Array.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < Array.GetLength(1); j++)
                    rowSum += Array[i, j];

                if (rowSum < minRowSum)
                {
                    minRowSum = rowSum;
                    indexMinRow = i;
                }
            }

        Console.WriteLine("\n Cтрока с наименьшей суммой элементов: ");
            for (int j = 0; j < Array.GetLength(1); j++)
            {
            Console.Write(Array[indexMinRow, j] + "\t");
            }
            return minRowSum;
          
}

// вывод

Console.WriteLine("\n Задайте прямоугольный двумерный массив: ");

int [,] matrix = GreateArray (4,7);
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();
SumStringArray(matrix);
