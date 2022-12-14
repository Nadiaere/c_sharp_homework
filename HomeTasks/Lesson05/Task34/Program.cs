// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
    array[index] = new Random().Next(100, 1000);
    index++;
  }
}

// метод подсчета четных элементов
int CountIsEven(int[] elements)
{
  int result = 0;

  int size = elements.Length;
  int i = 0;
  while (i < size)
  {
    if (elements[i] % 2 == 0) result++;
    i++;
  }

  return result;
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
Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами ");

int countElements = new Random().Next(0, 10);
int[] arr = CreateArray(countElements);
Fill(arr);
PrintGood(arr);
int even = CountIsEven(arr);
Console.WriteLine(PrintGood(arr));
Console.WriteLine("\n Количество чётных чисел в массиве : "+ even);


//int countElements = int.Parse(Console.ReadLine());    // ввод чисел с консоли