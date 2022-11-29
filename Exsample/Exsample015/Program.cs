// Работа с текстом. Дан текст,  в тексте вме пробелы нужно заменить черточками
// маленькие буквы к на большие К, большие С на маленькие с

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегородце,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"    есть вспомогательный функционал
//             01234   
// s [3] r указав идентификатор для того чтобы обратиться к конкр символу   

string Replace(string text, char oldValue, char newValue)  // Метод replace()возвращает новую строку с одним, несколькими или всеми совпадениями, patternзамененными на replacemen
{
    string result = string.Empty;
    int Length = text.Length;         // получить длину строки
    for (int i = 0; i < Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";  // результатт новой строки
        else result = result + $"{text[i]}";  // если аргумент Text то и обращаемся к тексту
    }

    return result;
}

string newText = Replace(text, ' ', '|');   // стринг и указываем что присвоить, пробелы меняем на черточки
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');

// Метод упордочивания сортировки массива

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)  // отдельная подзадача вывести массив на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)  // получение количества элементов
    {
       Console.Write($"{array[i]} ");    // можно сделать чтобы вывод осуществлялся в одну строку
    }
    Console.WriteLine();
}
// далее пишем метод который упорядочивает массив
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;  // определяем позицию на которую смотрим // теперь иещем тот самый минимальные элемент
        
        for (int j = i + 1; j < array.Length; j++)   // то что отсортировано начинается с i + позиции, если начинаем с поиска индекса i+1. то из общей длины делаем -1 стр 48
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];  // простой обмен двух переменных местами поменять то что нашли
        array[i] = array[minPosition];   // другими словами Функция SWAP в С — простой способ обменять значения двух переменных, которые содержат одинаковые типы данных
        array[minPosition] = temporary;  // сюда кладем элемент который был временным
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);