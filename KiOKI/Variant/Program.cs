using System;

namespace Variant
{
	static class Program
	{
		// ReSharper disable once UnusedParameter.Local
		static void Main(string[] args)
		{
			Console.Write("Номер по журналу: ");
			var n = Convert.ToInt32(Console.ReadLine());

			Console.Write("Количество заданий: ");
			var t = Convert.ToInt32(Console.ReadLine());

			var k = n % t + 1;

			Console.WriteLine("Вариант по лабораторной работе: {0}", k);
		}
	}
}
