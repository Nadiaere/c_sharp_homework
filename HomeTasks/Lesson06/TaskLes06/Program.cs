// Задача: доделать задачу сложения\вычитания двух многочленов.
// Реализовать красивый вывод.
// Подумать над перемножением*

// f(x) =  1*x^0 + 2*x^1 + 0*x^2 + 4*x^3 + 5*x^4+ 16*x^5
// g(x) =  10*x^0 + 11*x^1 + 4*x^2 

// сложение многочленов
int[] Sum(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    result[i] = f[i] + g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = g[i];
    else result[i] = f[i];
  }

  return result;
}

// разность многочленов

int[] Diff(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG < resultMax)
  {
    resultMax = powF;
    resultMin = powG;
  }

  int[] result = new int[resultMin];

  for (int i = 0; i < resultMax; i++)
  {
    result[i] = f[i] - g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = g[i];
    else result[i] = f[i];
  }

  return result;
}

string Print(int[] f)
{
string output = String.Empty;
  for (int i = 0; i < f.Length; i++)
  {

    int t = f[i];
    if (f[i] == 0) continue;
    if (f[i] < 0) { output += " - "; }
    else if (i != 0 && (i-1) !=0 ) { output += " + "; }

    if (t < 0) t = -t;
    if (i == 1) { output += $"{t}x"; }
    if (i == 0) { output += $"{t}"; }
    if (i != 1 && i != 0 && f[i] != 0) { output += $"{t}x^{i}"; }
  // //if (flag && f[i] != 0 && i < f.Length - 1) output += " + "
  }
  return output;
}
//умножение многочленов
int[] Multi (int[]f, int []g)
{
int size = f.Length + g.Length;
int[] result = new int[size];
for (int i=0; i<f.Length; i++)
    for (int j=0; j<g.Length;j++)
    {
        result[i+j] += f[i]*g[j];
    }
return result;
}

// вывод в консоль
int[] f = { 1, 4, 10, 0,};
//          1* x^0 + 2*x^1 + 0*x^2 + 4*x^3 + 5*x^4 + 6*x^5
int[] g = { 11, 3, -2, -5};
//f(x) = a0*x^0 + a1*x^1 + a2*x^2 + a3*x^3 + a4*x^4 + ....+ aN*x^N
Console.WriteLine("\n Вывести многочлен f: " + Print (f));
//Console.WriteLine(Print(f));
Console.WriteLine("\n Вывести многочлен g: " + Print (g));
//Console.WriteLine(Print(g));
int[] s = Sum(f, g);
int[] d = Diff(f, g);
Console.WriteLine("\n Сумма многочленов = " + Print(s));
//Console.WriteLine(Print(s));
Console.Write("\n Разность многочленов = " + Print (d));
//Console.WriteLine(Print(d));
int[] m = Multi(f,g);
Console.Write("\n Произведение многочленов = " + Print(m));
Console.WriteLine();

