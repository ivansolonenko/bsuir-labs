using System;
using System.Web.Mvc;

namespace Timetables.Common.Binders
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Struct | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
	public class AbstractModelBinderAttribute : CustomModelBinderAttribute
	{
		public override IModelBinder GetBinder()
		{
			return new AbstractModelBinder();
		}
	}
}