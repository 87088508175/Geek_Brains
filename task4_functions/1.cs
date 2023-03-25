using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Введите число A:");
		int a = Convert.ToInt32(Console.ReadLine()); // считываем число A

		Console.WriteLine("Введите степень B:");
		int b = Convert.ToInt32(Console.ReadLine()); // считываем степень B

		int result = 1;
		for (int i = 0; i < b; i++)
		{
			result *= a;
		}

		Console.WriteLine("{0} в степени {1} равно {2}", a, b, result);
	}
}

