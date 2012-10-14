using System;

namespace Lab03
{
	[Serializable]
	public class Department
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public long Employees { get; set; }

		public override string ToString()
		{
			return string.Format("Department {0} - {1} employees", Title, Employees);
		}
	}
}
