using System.IO;

namespace Timetables.Common.Serializers
{
	public class XmlSerializer<T> : Serializer<T>
	{
		public override T In(byte[] data)
		{
			var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
			var stream = new MemoryStream(data);
			return (T)serializer.Deserialize(stream);
		}

		public override byte[] Out(T data)
		{
			var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
			var stream = new MemoryStream();
			serializer.Serialize(stream, data);
			return stream.GetBuffer();
		}
	}
}