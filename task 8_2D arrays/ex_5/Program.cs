using System;

class Program
{
	static void Main()
	{
		int[,] arr = new int[4, 4]; // создаем двумерный массив

		int num = 1; // начальное значение для заполнения массива
		int size = 4; // размер массива

		int row = 0; // текущая строка
		int col = 0; // текущий столбец
		int maxRow = size - 1; // максимальная строка
		int maxCol = size - 1; // максимальный столбец
		int minRow = 0; // минимальная строка
		int minCol = 0; // минимальный столбец

		while (num <= size * size)
		{ // заполняем массив до последнего элемента
		  // заполняем верхнюю строку слева направо
			for (col = minCol; col <= maxCol; col++)
			{
				arr[minRow, col] = num++;
			}
			minRow++;

			// заполняем правый столбец сверху вниз
			for (row = minRow; row <= maxRow; row++)
			{
				arr[row, maxCol] = num++;
			}
			maxCol--;

			// заполняем нижнюю строку справа налево
			for (col = maxCol; col >= minCol; col--)
			{
				arr[maxRow, col] = num++;
			}
			maxRow--;

			// заполняем левый столбец снизу вверх
			for (row = maxRow; row >= minRow; row--)
			{
				arr[row, minCol] = num++;
			}
			minCol++;
		}

		// выводим массив
		for (row = 0; row < size; row++)
		{
			for (col = 0; col < size; col++)
			{
				Console.Write("{0,3}", arr[row, col]);
			}
			Console.WriteLine();
		}
	}
}