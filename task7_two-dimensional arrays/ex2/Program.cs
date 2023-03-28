using System;

class Program
{
	static void Main()
	{
		int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } }; // исходный двумерный массив

		Console.WriteLine("Введите позиции элемента (i,j):");
		int i = int.Parse(Console.ReadLine()); // ввод номера строки
		int j = int.Parse(Console.ReadLine()); // ввод номера столбца

		// проверяем, что введенные позиции входят в границы массива
		if (i < 0 || i >= arr.GetLength(0) || j < 0 || j >= arr.GetLength(1))
		{
			Console.WriteLine("Ошибка: элемент с такими позициями не найден.");
		}
		else
		{
			Console.WriteLine("Значение элемента ({0},{1}): {2}", i, j, arr[i, j]);
		}
	}
}