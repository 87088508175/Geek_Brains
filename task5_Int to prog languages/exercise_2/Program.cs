using System;

namespace SumOfOddPositionElements
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			int[] arr = new int[10];

			// Заполнение массива случайными числами
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = random.Next(1, 101);
			}

			Console.WriteLine("Массив из случайных чисел:");
			Console.WriteLine(string.Join(", ", arr));

			int sum = 0;

			// Нахождение суммы элементов, стоящих на нечетных позициях
			for (int i = 1; i < arr.Length; i += 2)
			{
				sum += arr[i];
			}

			Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
		}
	}
}