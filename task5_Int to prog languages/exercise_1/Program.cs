using System;

namespace EvenNumbersInArray
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			int[] arr = new int[10];

			// Заполнение массива случайными трехзначными числами
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = random.Next(100, 1000);
			}

			Console.WriteLine("Массив из случайных трехзначных чисел:");
			Console.WriteLine(string.Join(", ", arr));

			int count = 0;

			// Подсчет количества четных чисел в массиве
			foreach (int element in arr)
			{
				if (element % 2 == 0)
				{
					count++;
				}
			}

			Console.WriteLine($"Количество четных чисел в массиве: {count}");
		}
	}
}