using Newtonsoft.Json;
using Timetables.Common.Json;

namespace Timetables.Common.Serializers
{
	public class JsonSerializer<T> : Serializer<T>
	{
		public override T In(byte[] data)
		{
			var json = CurrentlyUsedEncoding.GetString(data);
			return JsonConvert.DeserializeObject<T>(json, new TimetableConverter());
		}

		public override byte[] Out(T data)
		{
			var json = JsonConvert.SerializeObject(data);
			return CurrentlyUsedEncoding.GetBytes(json);
		}
	}
}