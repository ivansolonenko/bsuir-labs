using Timetables.Common.Enums;

namespace Timetables.Common.Interfaces
{
	public interface IDataManager
	{
		void LoadFromFile(FileTypes inputFormat, byte[] fileContents);

		void SaveToFile(FileTypes outputFormat, out byte[] fileContents, out string charset);
	}
}
