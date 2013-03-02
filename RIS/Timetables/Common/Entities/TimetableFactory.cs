using System;
using Timetables.Common.Enums;
using Timetables.Common.Interfaces;
using Timetables.Models;

namespace Timetables.Common.Entities
{
	public static class TimetableFactory
	{
		public static ITimetable CreateInstance(TimetableTypes type)
		{
			switch (type)
			{
				case TimetableTypes.BusTimetable:
					return new BusTimetable { Id = Guid.NewGuid() };
				case TimetableTypes.PlaneTimetable:
					return new PlaneTimetable { Id = Guid.NewGuid() };
				case TimetableTypes.TrainTimetable:
					return new TrainTimetable { Id = Guid.NewGuid() };
				default:
					throw new ArgumentException();
			}
		}
	}
}