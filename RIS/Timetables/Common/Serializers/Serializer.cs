using System.Text;
using Timetables.Common.Interfaces;

namespace Timetables.Common.Serializers
{
	public abstract class Serializer<T> : ISerializer<T>
	{
		#region Properties

		public Encoding CurrentlyUsedEncoding
		{
			get { return Encoding.UTF8; }
		}

		#endregion

		#region Public Methods

		public abstract T In(byte[] data);
		public abstract byte[] Out(T data);

		#endregion
	}
}