using System;

class Program
{
	static void Main()
	{
		int[,,] arr = new int[2, 2, 2]; // создаем трехмерный массив

		int num = 10; // начальное значение для заполнения массива

		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				for (int k = 0; k < 2; k++)
				{
					arr[i, j, k] = num++; // заполняем массив неповторяющимися двузначными числами
				}
			}
		}

		// выводим массив построчно с индексами каждого элемента
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				for (int k = 0; k < 2; k++)
				{
					Console.WriteLine("arr[{0},{1},{2}] = {3}", i, j, k, arr[i, j, k]);
				}
			}
		}
	}
}