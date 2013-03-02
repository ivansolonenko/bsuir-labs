using System;
using Timetables.Common.Enums;
using Timetables.Common.Interfaces;

namespace Timetables.Common.Entities
{
	public abstract class BaseTimetable : ITimetable
	{
		public Guid Id { get; set; }

		public abstract TimetableTypes Type { get; }

		public DateTime DepartureDateTime { get; set; }
		public string DestinationCity { get; set; }
		public int TicketPrice { get; set; }
	}
}
