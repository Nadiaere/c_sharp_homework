// двумерные массивы. 
// Обязательно указывается [,]. тип данных, имя, оператор присваивания
// string[,] table = new string [2,3];
// строки обязательно , которая указывает размерность, столбцы
// таблица из строк        к-во строк(5 и столбцов 8)    
// int[,] matrix = new int[5,8];  в математике прямогульную таблицу чисел называют матрицей

string[,] table = new string [2, 5];
 // string.Empty - инициализаци для строк
//table[0,0] table[0,1]  table[0,2] table[0,4];   ! из примера если столбцов 5, то индекс до 4!
//table[1,0] table[1,1]  table[1,2] table[1,4]

// table[1, 2] = "слово";  // индексы и слов и столбов так же от ноля

// for (int rows = 0; rows < 2; rows++)   // строки исходя из примера не больше2
// {
//     for (int colums = 0; colums < 5; colums++)   // столбцы
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");     //интерполяция через обращение к инексу строки и столбца
//     }
// }
// !!!! имя массива.GetLength(0) - возвращает количество строк в массиве
// !!!! имя массива.GetLength(1) - возвращает количество столбцов в матрице

int[,] matrix = new int[3,4];  // 3.4 дл самого массива можно использовать

void PrintArray(int[,] matr)   // чтобы вывести на печать делаем метод ля текущего кода
{
    for (int i = 0; i < matr.GetLength(0); i++)  // в момент работы с циклами или методами через гетленд получаем колич строк - GetLength(0)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"-{matr[i, j]}-");  // эта команта Сonsole.WriteLine(); выводит строки и столбцы
        }
        Console.WriteLine();
    }
}
PrintArray(matrix);

// дополн метод который будет заполнять матрицу числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);  // [1; 10]
        }
    }
}

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine("Hello, World!");

int[,] pic = new int [,];

void PrintImage(int[,] image)   // чтобы вывести на печать делаем метод ля текущего кода
{
    for (int i = 0; i < image.GetLength(0); i++)  // в момент работы с циклами или методами через гетленд получаем колич строк - GetLength(0)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"-{image[i, j]}-"); 
            if(image[i,j] == 0) Console.Write($" ");  // печать пробела
            else Console.WriteLine($"+");
            
        }  
}

PrintImage(pic);}  // метод с ошибками, без массива, его отработать

// далее метод который будет закрашиватьк картинку

void FillImage(int row, int col)
{
    if(pic[row, col] ==0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);  // подняться на строчку выше
        FillImage(row, col -1);  // идем в той же строке но влево, то есть меняем позицию столбика
        FillImage(row + 1, col);   // идем вних и увеличиваем позицию строки
        FillImage(row, col + 1);  // идем вправо оставаясь в той же самой строке
    }
}

PrintImage(pic);
FillImage(13, 13);  // 13,13 это точка которая д.б. внутри изображения
PrintImage(pic);
