// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int AkkermanFunc(int M, int N)
	{
		if(M == 0)
		{
			return N + 1;
		}
		if(M > 0 && N == 0)
		{
			return AkkermanFunc(M - 1, 1);
		}
			return AkkermanFunc(M - 1, AkkermanFunc(M, N - 1));
	}
		
Console.WriteLine($"\n Вычисление функции Аккермана ({M}, {N}) = {AkkermanFunc(M, N)}");
	
