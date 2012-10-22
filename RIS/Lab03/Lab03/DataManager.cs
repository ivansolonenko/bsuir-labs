using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace Lab03
{
	public static class DataManager
	{
		private const string Filename = "data.xml";
		private static List<Department> _departments = new List<Department>();

		public static void Add(Department department)
		{
			Load();
			_departments.Add(department);
			Save();
		}

		public static Department FindByEmployeesCount(int count)
		{
			Load();
			return _departments.FirstOrDefault(x => x.Employees == count);
		}

		public static IEnumerable<Department> GetAll()
		{
			Load();
			return _departments;
		}

		private static void Load()
		{
			try
			{
				using (var fstream = new FileStream(Filename, FileMode.Open))
				{
					var xmlFormatter = new XmlSerializer(typeof(List<Department>));
					_departments = (List<Department>)xmlFormatter.Deserialize(fstream);
				}
			}
			catch
			{
			}
		}

		private static void Save()
		{
			try
			{
				using (var fstream = new FileStream(Filename, FileMode.Create))
				{
					var xmlFormatter = new XmlSerializer(typeof(List<Department>));
					xmlFormatter.Serialize(fstream, _departments);
				}
			}
			catch
			{
			}
		}
	}
}
