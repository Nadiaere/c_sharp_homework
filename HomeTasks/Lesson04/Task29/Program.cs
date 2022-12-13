// Задача 29: Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//1.1 метод, который считывает количество элементов от пользователя из консоли
int GetNumber(string text)
  {
  Console.Write(text);
  int value = int.Parse(Console.ReadLine());
  return value;
  }

// 1. метод, создающий массив с указанным количеством эл.
int[] CreateArray(int count)
  {
    return new int[count];
  }

// 2. метод, заполняющий массив поэлементно *от пользователя
void FillArray(int[] array)
  {
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
      array[index] = GetNumber($"array[{index}]: ");
      index++;
    }
  }

// 3. метод, печатающий массив 
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

int count = GetNumber("Введите количество эл массива:\t");      //  \t отступ в виде таб
int[] arr = CreateArray(count);
FillArray(arr);
PrintGood(arr);
Console.WriteLine("\nВывод массива " + PrintGood(arr));  //  \n переход на новую строку