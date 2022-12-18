﻿
//Сделать вывод только нечетных коэффициентов у треугольника распечатайте хотя бы 120 строк


using static library;

//Console.Clear();

int[,] tr = CreateTriangle(120);
PrintTriangle(tr);
int[] koeff = GetKoeff(tr, 5);
Console.WriteLine();

for (int i = 0; i < koeff.Length; i++)
{
  Console.Write($"{koeff[i]}*a^{koeff.Length - 1 - i}*b^{i} + ");
}


// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         {
//             int[,] CreateTriangle(int row)
//             {
//                 int[,] triangle = new int[row, row];
//                 for (int i = 0; i < row; i++)
//                 {
//                     triangle[i, 0] = 1;
//                     triangle[i, i] = 1;
//                 }

//                 for (int i = 2; i < row; i++)
//                 {
//                     for (int j = 1; j <= i; j++)
//                     {
//                         triangle[i, j] =
//                         triangle[i - 1, j - 1] + triangle[i - 1, j];
//                     }
//                 }
//                 return triangle;
//             }
//         }

//         {
//             void PrintTriangle(int[,] triangle)
//             {
//                 int row = triangle.GetLength(0);
//                 for (int i = 0; i < row; i++)
//                 {
//                     for (int j = 0; j < row; j++)
//                     {
//                         if (triangle[i, j] % 2 != 0)
//                             //Console.Write($"{triangle[i, j],4}");
//                             Console.Write(" * ");
//                         else
//                         {
//                             Console.Write(" ");
//                         }
//                     }
//                     Console.WriteLine();
//                 }
//             }
//         }

//         {
//             static int[] GetKoeff(int[,] tr, int pow)
//             {
//                 int[] row = new int[pow + 1];
//                 for (int i = 0; i <= pow; i++)
//                 {
//                     row[i] = tr[pow, i];
//                 }
//                 return row;
//             }
//         }




// int[,] tr = CreateTriangle(20);
//         PrintTriangle(tr);
//         int[] koeff = GetKoeff(tr, 2);

//         System.Console.WriteLine(string.Join(' ', koeff));

//         System.Console.WriteLine(koeff.Length);

//         for (int i = 0; i < koeff.Length; i++)
//         {
//             Console.Write($"{koeff[i]}*a^{koeff.Length - 1 - i}*b^{i} + ");
//         }
//         System.Console.WriteLine();
    
