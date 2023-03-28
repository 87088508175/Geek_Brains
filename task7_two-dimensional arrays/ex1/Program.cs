using System;

class Program
{
	static void Main()
	{
		int m = 3; // количество строк
		int n = 4; // количество столбцов
		double[,] arr = new double[m, n]; // создаем двумерный массив

		// заполняем массив случайными числами
		Random rand = new Random();
		for (int i = 0; i < m; i++)
		{
			for (int j = 0; j < n; j++)
			{
				arr[i, j] = rand.NextDouble();
			}
		}

		// выводим массив на экран
		for (int i = 0; i < m; i++)
		{
			for (int j = 0; j < n; j++)
			{
				Console.Write("{0:0.00} ", arr[i, j]);
			}
			Console.WriteLine();
		}
	}
}