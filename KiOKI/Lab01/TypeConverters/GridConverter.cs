using System;
using System.ComponentModel;
using System.Globalization;

namespace Lab01.TypeConverters
{
	internal class GridConverter : TypeConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value == null)
				return "(null)";

			if (destinationType == typeof(string))
			{
				return value.ToString();
			}

			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
