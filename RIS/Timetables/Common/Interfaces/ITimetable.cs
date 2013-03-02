using System;
using Timetables.Common.Binders;
using Timetables.Common.Enums;

namespace Timetables.Common.Interfaces
{
	[AbstractModelBinder]
	public interface ITimetable
	{
		Guid Id { get; set; }
		TimetableTypes Type { get; }
		DateTime DepartureDateTime { get; set; }
		string DestinationCity { get; set; }
		int TicketPrice { get; set; }
	}
}
