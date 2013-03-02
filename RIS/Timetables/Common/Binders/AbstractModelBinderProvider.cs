using System;
using System.Web.Mvc;

namespace Timetables.Common.Binders
{
	public class AbstractModelBinderProvider : IModelBinderProvider
	{
		public IModelBinder GetBinder(Type modelType)
		{
			if (modelType.IsAbstract || modelType.IsInterface)
				return new AbstractModelBinder();

			return null;
		}
	}
}