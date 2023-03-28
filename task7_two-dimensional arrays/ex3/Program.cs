using System;

class Program
{
	static void Main()
	{
		int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } }; // исходный двумерный массив

		int m = arr.GetLength(0); // количество строк
		int n = arr.GetLength(1); // количество столбцов

		// вычисляем среднее арифметическое элементов в каждом столбце
		double[] averages = new double[n];
		for (int j = 0; j < n; j++)
		{
			int sum = 0;
			for (int i = 0; i < m; i++)
			{
				sum += arr[i, j];
			}
			averages[j] = (double)sum / m;
		}

		// выводим результаты на экран
		for (int j = 0; j < n; j++)
		{
			Console.WriteLine("Среднее арифметическое элементов в столбце {0}: {1}", j, averages[j]);
		}
	}
}