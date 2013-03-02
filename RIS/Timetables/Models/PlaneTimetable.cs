using System;
using Timetables.Common.Binders;
using Timetables.Common.Entities;
using Timetables.Common.Enums;

namespace Timetables.Models
{
	[AbstractModelBinder]
	public class PlaneTimetable : BaseTimetable
	{
		public override TimetableTypes Type
		{
			get { return TimetableTypes.PlaneTimetable; }
		}

		public int FlightNumber { get; set; }

		public DateTime CheckoutDeadlineTime { get; set; }

		public string DepartureAirport { get; set; }

		public int DepartureAirportDistanceFromCityCentre { get; set; }

		public string DestinationAirport { get; set; }

		public int NumberOfChanges { get; set; }

		public string TicketType { get; set; }

		public string Airline { get; set; }

		public int MaxLuggageWeight { get; set; }

		public int MaxCarryonWeight { get; set; }

		public DateTime ArrivalDateTime { get; set; }

		public override string ToString()
		{
			return string.Format(@"Departure Airport: {0}
														Distance From City Centre: {1}
														Destination Airport: {2}
														Number Of Changes: {3}
														Airline: {4}
														Max Luggage Weight: {5}
														Max Carryon Weight: {6}
														Arrival Date/Time: {7}",
				DepartureAirport,
				DepartureAirportDistanceFromCityCentre,
				DestinationAirport,
				NumberOfChanges,
				Airline,
				MaxLuggageWeight,
				MaxCarryonWeight,
				ArrivalDateTime);
		}
	}
}
