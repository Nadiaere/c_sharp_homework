// / Массивы.

void FillArray(int[] collection)     
{
    int Lenght = collection.Length;
    int index = 0;
    while (index < Lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)                             
{
    int count = col.Length;    
    int Position = 0;
    while (Position < count)
    {
        Console.WriteLine(col[Position]);     
        Position++;
    }
}
int IndexOf(int[] collection, int find)  // метод который возвращает позицию
{
    int count = collection.Length;
    int index = 0;
    int Position = 0;

    while (index < count)
    {
        if(collection[index] == find)
        {
           Position = index; 
           break;
        }
        index++;
    }
    return Position;
}

int[] array = new int [10];

FillArray(array); 
array[4] = 4;
array[6] = 4;
PrintArray(array); 
Console.WriteLine();  

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

// если нужно найти число которого нет например int pos = IndexOf(array, 444);
// если запусти окажетс что позиция 0 (самая нижняя строчка)
// то по умолчанию можно сделать int Position = -1 (стр 27)
// и если нижняя строка нам выдаст результат -1 значит такого элемента нет
 
