using System;

class Program
{
	static void Main()
	{
		int[,] A = { { 2, 4 }, { 3, 2 } }; // первая матрица
		int[,] B = { { 3, 4 }, { 3, 3 }, }; // вторая матрица

		int m = A.GetLength(0); // количество строк первой матрицы
		int n = B.GetLength(1); // количество столбцов второй матрицы
		int p = A.GetLength(1); // количество столбцов первой матрицы и количество строк второй матрицы

		int[,] C = new int[m, n]; // результирующая матрица

		// вычисляем произведение матриц
		for (int i = 0; i < m; i++)
		{
			for (int j = 0; j < n; j++)
			{
				for (int k = 0; k < p; k++)
				{
					C[i, j] += A[i, k] * B[k, j];
				}
			}
		}

		// выводим результаты на экран
		Console.WriteLine("Результат умножения матриц:");
		for (int i = 0; i < m; i++)
		{
			for (int j = 0; j < n; j++)
			{
				Console.Write("{0} ", C[i, j]);
			}
			Console.WriteLine();
		}
	}
}