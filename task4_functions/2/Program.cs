using System;

namespace SumOfDigits
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число: ");
			string input = Console.ReadLine();

			int sum = 0;

			foreach (char digit in input)
			{
				if (char.IsDigit(digit))
				{
					sum += int.Parse(digit.ToString());
				}
			}

			Console.WriteLine($"Сумма цифр числа {input}: {sum}");
		}
	}
}
