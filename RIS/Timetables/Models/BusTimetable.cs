using System;
using Timetables.Common.Binders;
using Timetables.Common.Entities;
using Timetables.Common.Enums;

namespace Timetables.Models
{
	[AbstractModelBinder]
	public class BusTimetable : BaseTimetable
	{
		public override TimetableTypes Type
		{
			get { return TimetableTypes.BusTimetable; }
		}

		public int RouteNumber { get; set; }

		public string DepartureStation { get; set; }

		public int DeparturePlatform { get; set; }

		public string DestinationStation { get; set; }

		public string BusBrand { get; set; }

		public TimeSpan TripTime { get; set; }

		public override string ToString()
		{
			return string.Format(@"Departure Station: {0},
													Departure Platform: {1},
													Destination Station: {2},
													Bus Brand: {3},
													Trip Time: {4}",
				DepartureStation,
				DeparturePlatform,
				DestinationStation,
				BusBrand,
				TripTime);
		}
	}
}
