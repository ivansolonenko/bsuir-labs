using System.ComponentModel;
using Lab01.Properties;

namespace Lab01.Attributes
{
	public class LocalizedCategoryAttribute : CategoryAttribute
	{
		private readonly string _resourceName;

		public LocalizedCategoryAttribute(string resourceName)
		{
			_resourceName = resourceName;
		}

		protected override string GetLocalizedString(string value)
		{
			return Resources.ResourceManager.GetString(_resourceName);
		}
	}
}
