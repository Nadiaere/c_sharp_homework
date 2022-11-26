// Функция

// индекс массива всегда начинается с "0", есть если элементов 9 то заканчиваться он будет на 8

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int[] array = {13, 211, 13, 324, 55, 6, 779, 83, 19}; // массив

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])); 

Console.WriteLine(max);
