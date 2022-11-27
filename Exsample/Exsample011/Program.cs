// Задачи с массивом. Есть одномерный массив из N элементов, требуется найти элеемент массива равный Find (найти)

int[] array = {1, 12, 31, 4, 18, 15, 18};

int n = array.Length;

int find = 18;

int index = 0;

while (index < n)
{
   if (array[index] == find)
   {
    Console.WriteLine(index);
    break; // прерви
   }
    index = index + 1; // программисы пишут так index ++ 
}


Console.WriteLine("Hello, World!");
