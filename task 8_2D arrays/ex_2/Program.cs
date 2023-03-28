using System;

class Program
{
	static void Main()
	{
		int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } }; // исходный прямоугольный двумерный массив

		int m = arr.GetLength(0); // количество строк
		int n = arr.GetLength(1); // количество столбцов

		// находим строку с наименьшей суммой элементов
		int minSumRow = 0;
		int minSum = int.MaxValue;
		for (int i = 0; i < m; i++)
		{
			int sum = 0;
			for (int j = 0; j < n; j++)
			{
				sum += arr[i, j];
			}
			if (sum < minSum)
			{
				minSum = sum;
				minSumRow = i;
			}
		}

		// выводим результаты на экран
		Console.WriteLine("Строка с наименьшей суммой элементов:");
		for (int j = 0; j < n; j++)
		{
			Console.Write("{0} ", arr[minSumRow, j]);
		}
		Console.WriteLine();
	}
}