using System;

class Program
{
	static void Main()
	{
		int M = 1; // задаем значение M
		int N = 15; // задаем значение N

		int sum = SumNumbers(M, N); // вызываем функцию для вычисления суммы чисел
		Console.WriteLine("Сумма чисел от {0} до {1} равна {2}", M, N, sum); // выводим результат
	}

	static int SumNumbers(int m, int n)
	{
		if (m == n)
		{ // если m и n равны, то возвращаем m
			return m;
		}
		else if (m > n)
		{ // если m больше n, то возвращаем 0
			return 0;
		}
		else
		{ // в противном случае, рекурсивно вызываем функцию для суммирования чисел от m+1 до n и добавляем к ней m
			return m + SumNumbers(m + 1, n);
		}
	}
}