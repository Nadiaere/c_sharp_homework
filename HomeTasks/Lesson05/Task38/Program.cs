// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int count)
  {
    return new double[count];
  }


void Fill(double[] array)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.NextDouble();
    }
  }

string PrintGood(double[] numbers)
  {
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
      result += (string.Format("{0:F3}   ",numbers[i]));
      i++;
    }
    return result + "]";
  }

// метод, который находит макcиммальное значение
double NumberMax (double[] numbers)
{
    int ind = 0;
    double max = numbers[0];
    while (ind < numbers.Length)
    {
        if (numbers[ind] > max)
        {
            max = numbers[ind];
        }
        ind++;
    }
return max;
}

// метод, который нахождит минимальное значение
double NumberMin (double[] numbers)
{
    int ind = 0;
    double min = numbers[0];
    while (ind < numbers.Length)
    {
        if (numbers[ind] < min)
        {
            min = numbers[ind];
        }
        ind++;
    }
return min;
}

// Клиентский код
Console.WriteLine("Задайте массив вещественных чисел: ");

double[] arr = CreateArray(5);
Fill(arr);
Console.WriteLine(PrintGood(arr));
double maxRes = NumberMax(arr);
Console.WriteLine(string.Format("{0:F3}   ",maxRes));
double minRes = NumberMin(arr);
Console.WriteLine(string.Format("{0:F3}   ",minRes));
double diff = maxRes - minRes;

Console.WriteLine("\n Разница между максимальным и минимальным элементов массива = "+ diff);
