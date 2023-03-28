using System;

class Program
{
	static void Main()
	{
		int[,] arr = { { 3, 2, 1 }, { 6, 5, 4 }, { 9, 8, 7 } }; // исходный двумерный массив

		int m = arr.GetLength(0); // количество строк
		int n = arr.GetLength(1); // количество столбцов

		// упорядочиваем элементы каждой строки по убыванию
		for (int i = 0; i < m; i++)
		{
			// используем метод Array.Sort с обратным порядком сортировки
			Array.Sort(arr, i * n, n, new Comparison<int>((x, y) => y.CompareTo(x)));
		}

		// выводим результаты на экран
		for (int i = 0; i < m; i++)
		{
			for (int j = 0; j < n; j++)
			{
				Console.Write("{0} ", arr[i, j]);
			}
			Console.WriteLine();
		}
	}
}