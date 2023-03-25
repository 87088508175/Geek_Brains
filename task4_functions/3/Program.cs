using System;

namespace ArrayOutput
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 2, 5, 7, 19, 6, 1, 33 };

			Console.WriteLine("Элементы массива:");

			foreach (int element in arr)
			{
				Console.WriteLine(element);
			}
		}
	}
}