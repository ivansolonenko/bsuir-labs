using System;
using System.Collections.Generic;

namespace Timetables.Common.Data
{
	public class LogManager
	{
		private static LogManager _instance;

		public static LogManager Instance
		{
			get { return _instance ?? (_instance = new LogManager()); }
		}

		private ICollection<string> _logMessages;

		public ICollection<string> LogMessages
		{
			get { return _logMessages ?? (_logMessages = new List<string>()); }
		}

		private LogManager()
		{
			DataManager.Instance.DataCollectionChanged_Add += DataCollectionChanged_Add;
			DataManager.Instance.DataCollectionChanged_Edit += DataCollectionChanged_Edit;
		}

		private void DataCollectionChanged_Add(Guid guid)
		{
			_logMessages.Add(string.Format("Record with ID {0} was added", guid));
		}

		private void DataCollectionChanged_Edit(Guid guid)
		{
			_logMessages.Add(string.Format("Record with ID {0} was edited", guid));
		}
	}
}
