// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int count)
{
  return new int[count];
}

void Fill(int[] array)
{
  int size = array.Length;
  int index = 0;
  while (index < size)
  {
    array[index] = new Random().Next(10, 100);
    index++;
  }
}

// метод, находящий сумму элементов , стоящих на нечетных позициях
int SumOddIndex(int[] array)   
{
int index = 0;
int sum = 0;
    while (index<array.Length)
    {
        if ((index) % 2 == 1)
        sum = sum + array[index];
        index++;
    }
    return sum;
}


// метод печати
string PrintGood(int[] numbers)
{
  int size = numbers.Length;
  int i = 0;
  string result = "[ ";

  while (i < size)
  {
    result += ($"{numbers[i]} ");
    i++;
  }
  return result + "]";
}

// Клиентский код
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами ");

int countElements = new Random().Next(-0, 10);
int[] arr = CreateArray(countElements);
Fill(arr);
PrintGood(arr);
int SummI = SumOddIndex(arr);
Console.WriteLine(PrintGood(arr));
Console.WriteLine("\n Сумма элементов, стоящих на нечётных позициях =: "+ SummI);

