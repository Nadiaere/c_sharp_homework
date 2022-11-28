// Массивы.
// void метод который ничего не возвращает
// FillArray(out int[] arr), функция, которая создает и заполняет новый массив C#

void FillArray(int[] collection)     // collection - аргумент
{
    int Lenght = collection.Length;
    int index = 0;
    while (index < Lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)                              //  Метод печати
{
    int count = col.Length;    // количество элементов
    int Position = 0;
    while (Position < count)
    {
        Console.WriteLine(col[Position]);     // вывод текущей позиции элемента
        Position++;
    }

}
int [] array = new int [10];
FillArray(array);   // метод который заполнил массив
PrintArray(array);   // метод печати




 
