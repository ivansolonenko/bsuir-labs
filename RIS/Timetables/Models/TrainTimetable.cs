using System;
using Timetables.Common.Binders;
using Timetables.Common.Entities;
using Timetables.Common.Enums;

namespace Timetables.Models
{
	[AbstractModelBinder]
	public class TrainTimetable : BaseTimetable
	{
		public override TimetableTypes Type
		{
			get { return TimetableTypes.TrainTimetable; }
		}

		public int TrainNumber { get; set; }

		public string DepartureStation { get; set; }

		public int DeparturePlatform { get; set; }

		public string DestinationStation { get; set; }

		public string TicketType { get; set; }

		public DateTime ArrivalDateTime { get; set; }

		public override string ToString()
		{
			return string.Format(@"Departure Station: {0},
													Departure Platform: {1},
													Destination Station: {2},
													Ticket Type: {3}
													Arrival Date/Time: {4}",
				DepartureStation,
				DeparturePlatform,
				DestinationStation,
				TicketType,
				ArrivalDateTime);
		}
	}
}
