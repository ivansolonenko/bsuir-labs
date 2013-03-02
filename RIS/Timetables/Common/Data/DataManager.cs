using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Timetables.Common.Enums;
using Timetables.Common.Interfaces;
using Timetables.Common.Serializers;

namespace Timetables.Common.Data
{
	public class DataManager : IDataManager
	{
		private static DataManager _instance;

		public static DataManager Instance
		{
			get { return _instance ?? (_instance = new DataManager()); }
		}

		private ICollection<ITimetable> _dataCollection;

		public ICollection<ITimetable> DataCollection
		{
			get { return _dataCollection ?? (_dataCollection = new List<ITimetable>()); }
		}

		private DataManager()
		{
		}

		#region Events

		public delegate void DataCollectionChangedDelegate(Guid guid);

		public event DataCollectionChangedDelegate DataCollectionChanged_Add;
		public event DataCollectionChangedDelegate DataCollectionChanged_Edit;

		#endregion

		#region Methods

		public void Add(ITimetable entry)
		{
			_dataCollection.Add(entry);

			if (DataCollectionChanged_Add != null)
				DataCollectionChanged_Add(entry.Id);
		}

		public void Edit(Guid id, ITimetable entry)
		{
			var model = _dataCollection.SingleOrDefault(x => x.Id == id);
			model = entry;

			if (DataCollectionChanged_Edit != null)
				DataCollectionChanged_Edit(entry.Id);
		}

		public void LoadFromFile(FileTypes inputFormat, Stream fileStream)
		{
			using (var ms = new MemoryStream())
			{
				fileStream.CopyTo(ms);
				LoadFromFile(inputFormat, ms.GetBuffer());
			}
		}

		public void LoadFromFile(FileTypes inputFormat, byte[] fileContents)
		{
			var serializer = SerializerFactory<ICollection<ITimetable>>.CreateInstance(inputFormat);
			_dataCollection = serializer.In(fileContents);
		}

		public void SaveToFile(FileTypes outputFormat, out byte[] fileContents, out string charset)
		{
			var serializer = SerializerFactory<ICollection<ITimetable>>.CreateInstance(outputFormat);
			fileContents = serializer.Out(_dataCollection);
			charset = serializer.CurrentlyUsedEncoding.WebName;
		}

		#endregion
	}
}
