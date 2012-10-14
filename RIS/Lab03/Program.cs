using System;

namespace Lab03
{
	static class Program
	{
		static void Main(string[] args)
		{
			int choice;
			do
			{
				Console.WriteLine("1 - Добавить");
				Console.WriteLine("2 - Просмотреть всех");
				Console.WriteLine("3 - Найти по количеству сотрудников");
				Console.WriteLine("0 - Выход");

				choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Console.WriteLine("Введите название и количество сотрудников:");
						var enterprise = new Department
															{
																Id = Guid.NewGuid(),
																Title = Console.ReadLine(),
																Employees = Convert.ToInt64(Console.ReadLine())
															};
						DataManager.Add(enterprise);
						break;

					case 2:
						Console.WriteLine("Подразделения:");
						foreach (var item in DataManager.GetAll())
							Console.WriteLine(item);
						break;

					case 3:
						Console.WriteLine("Количество сотрудников:");
						var count = Convert.ToInt32(Console.ReadLine());
						var employee = DataManager.FindByEmployeesCount(count);
						Console.WriteLine(employee);
						break;
				}
			} while (choice > 0);
		}
	}
}
