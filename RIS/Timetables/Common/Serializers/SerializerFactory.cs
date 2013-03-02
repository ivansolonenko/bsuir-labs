using System;
using System.Text;
using Timetables.Common.Enums;
using Timetables.Common.Interfaces;

namespace Timetables.Common.Serializers
{
	public static class SerializerFactory<T>
	{
		public static ISerializer<T> CreateInstance(FileTypes type)
		{
			switch (type)
			{
				case FileTypes.CSV:
					throw new NotImplementedException();
				case FileTypes.JSON:
					return new JsonSerializer<T>();
				case FileTypes.XML:
					return new XmlSerializer<T>();
				default:
					throw new ArgumentException();
			}
		}
	}
}