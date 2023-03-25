using System;

class Program
{
	static void Main(string[] args)
	{
		// Запрос значений у пользователя
		Console.Write("Введите значение k1: ");
		double k1 = double.Parse(Console.ReadLine());

		Console.Write("Введите значение b1: ");
		double b1 = double.Parse(Console.ReadLine());

		Console.Write("Введите значение k2: ");
		double k2 = double.Parse(Console.ReadLine());

		Console.Write("Введите значение b2: ");
		double b2 = double.Parse(Console.ReadLine());

		// Рассчитываем координаты точки пересечения
		double x = (b2 - b1) / (k1 - k2);
		double y = k1 * x + b1;

		// Выводим результат
		Console.WriteLine($"Точка пересечения: ({x}, {y})");

		// Ждем, пока пользователь не нажмет Enter, чтобы закрыть консольное окно
		Console.ReadLine();
	}
}