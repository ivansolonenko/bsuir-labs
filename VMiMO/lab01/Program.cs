using System;
using labs.Calculations;
using labs.Entities;
using labs.Helpers;

namespace lab01
{
	static class Program
	{
		// ReSharper disable UnusedParameter.Local
		static void Main(string[] args)
		// ReSharper restore UnusedParameter.Local
		{
			Console.Write("Количество переменных: ");
			var cols = Helpers.StringToNumber<int>(Console.ReadLine());

			Console.Write("Количество строк: ");
			var rows = Helpers.StringToNumber<int>(Console.ReadLine());

			try
			{
				var equationSystem = new EquationSystem();

				for (var i = 0; i < rows; i++)
				{
					Console.Write("Коэффициенты {0} уравнения: ", i + 1);
					var coefficients = Helpers.StringToEnumerable<double>(Console.ReadLine(), cols);
					equationSystem.Coefficients.Add(coefficients);
				}

				Console.Write("Результаты: ");
				var values = Helpers.StringToEnumerable<double>(Console.ReadLine(), rows);
				equationSystem.Values = values;

				Console.WriteLine("Ответ: {0}", equationSystem.Gauss(PrettyPrint.True));
			}
			catch (ApplicationException ex)
			{
				Console.WriteLine("Ошибка: {0}", ex.Message);
			}
		}
	}
}
