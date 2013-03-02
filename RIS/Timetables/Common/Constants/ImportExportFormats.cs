using System;
using System.Collections.Generic;
using System.Linq;
using Timetables.Common.Enums;

namespace Timetables.Common.Constants
{
	public static class ImportExportFormats
	{
		private static readonly ICollection<Tuple<FileTypes, string, string>> Values = new List
			<Tuple<FileTypes, string, string>>
			{
				new Tuple<FileTypes, string, string>(FileTypes.CSV, "text/csv", ".csv"),
				new Tuple<FileTypes, string, string>(FileTypes.JSON, "application/json", ".json"),
				new Tuple<FileTypes, string, string>(FileTypes.XML, "text/xml", ".xml")
			};

		public static string GetExtension(FileTypes fileType)
		{
			return Values.Single(x => x.Item1 == fileType).Item3;
		}

		public static string GetMime(FileTypes fileType)
		{
			return Values.Single(x => x.Item1 == fileType).Item2;
		}
	}
}
