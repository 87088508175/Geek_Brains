using System;

class Program
{
	static void Main()
	{
		int N = 5; // задаем значение N

		PrintNumbers(N); // вызываем функцию для вывода чисел
	}

	static void PrintNumbers(int n)
	{
		if (n > 0)
		{ // проверяем, что число n больше 0
			Console.WriteLine(n); // выводим число n
			PrintNumbers(n - 1); // вызываем функцию рекурсивно для числа n-1
		}
	}
}