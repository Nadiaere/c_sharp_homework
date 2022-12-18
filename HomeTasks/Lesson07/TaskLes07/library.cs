public static class library
{
public static int[,] CreateTriangle(int row)
{
  int[,] triangle = new int[row, row];
  for (int i = 0; i < row; i++)
  {
    triangle[i, 0] = 1;
    triangle[i, i] = 1;
  }
  for (int i = 2; i < row; i++)
  {
    for (int j = 1; j <= i; j++)
    {
      triangle[i, j] =
      triangle[i - 1, j - 1] + triangle[i - 1, j];
    }
  }
  return triangle;
}
public static void PrintTriangle(int[,] triangle)
{
  int row = triangle.GetLength(0);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < row; j++)
    {
      if (triangle[i, j] % 2!= 0)
      //Console.Write($"{triangle[i, j],4}");
        Console.Write("*");
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
  }

}

//  public static factorial(int n)
//         {
//             float i, x = 1;
//             for (i = 1; i <= n; i++)
//             {
//                 x *= i;
//             }
//             return x;
//         }

// int
// public static int[] binomial (int[,] pos)
// {
//   int koef = 1;
//   int i;
//   for (i = pos + 1; i <= row; i++)
//     koef = koef * i;
//   for (i = 1; i < (row - pos + 1); i++)
//     koef = koef / i;
//   return koef;
// }

public static int[] GetKoeff(int[,] tr, int pow)
{
  int[] row = new int[pow + 1];
  for (int i = 0; i <= pow; i++)
  {
    row[i] = tr[pow, i];
  }
  return row;
}


  
}