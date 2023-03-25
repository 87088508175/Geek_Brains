using System;

namespace DifferenceBetweenMaxAndMin
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] arr = new double[] { 3.14, 2.71, 1.62, 4.20, 0.99 };

			Console.WriteLine("Массив вещественных чисел:");
			Console.WriteLine(string.Join(", ", arr));

			double max = arr[0];
			double min = arr[0];

			// Нахождение максимального и минимального элементов массива
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
				if (arr[i] < min)
				{
					min = arr[i];
				}
			}

			double difference = max - min;

			Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
		}
	}
}