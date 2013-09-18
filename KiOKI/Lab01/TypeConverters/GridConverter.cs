using System;
using System.ComponentModel;
using System.Globalization;
using Lab01.Properties;

namespace Lab01.TypeConverters
{
	internal class GridConverter : TypeConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value == null)
				return Resources.NotSet;

			if (destinationType == typeof(string))
				return Resources.Grid_CellsSelected;

			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
