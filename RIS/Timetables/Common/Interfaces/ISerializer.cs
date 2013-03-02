using System.Text;

namespace Timetables.Common.Interfaces
{
	public interface ISerializer<T>
	{
		Encoding CurrentlyUsedEncoding { get; }

		T In(byte[] data);

		byte[] Out(T data);
	}
}