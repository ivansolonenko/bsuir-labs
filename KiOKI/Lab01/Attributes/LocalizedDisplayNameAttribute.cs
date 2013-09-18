using System.ComponentModel;
using Lab01.Properties;

namespace Lab01.Attributes
{
	public class LocalizedDisplayNameAttribute : DisplayNameAttribute
	{
		private readonly string _resourceName;

		public LocalizedDisplayNameAttribute(string resourceName)
		{
			_resourceName = resourceName;
		}

		public override string DisplayName
		{
			get
			{
				return Resources.ResourceManager.GetString(_resourceName);
			}
		}
	}
}
