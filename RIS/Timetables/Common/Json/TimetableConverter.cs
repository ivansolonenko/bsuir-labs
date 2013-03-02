using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Timetables.Common.Entities;
using Timetables.Common.Enums;
using Timetables.Common.Interfaces;

namespace Timetables.Common.Json
{
	public class TimetableConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var jObject = JObject.Load(reader);
			var target = Create(objectType, jObject);
			serializer.Populate(jObject.CreateReader(), target);
			return target;
		}

		public override bool CanConvert(Type objectType)
		{
			return typeof(ITimetable).IsAssignableFrom(objectType);
		}

		private static ITimetable Create(Type objectType, JObject jObject)
		{
			if (jObject["Type"] != null)
			{
				TimetableTypes type;
				var sType = jObject["Type"].Value<string>();
				if (!string.IsNullOrWhiteSpace(sType) && Enum.TryParse(sType, out type))
					return TimetableFactory.CreateInstance(type);
			}
			throw new InvalidDataException();
		}
	}
}