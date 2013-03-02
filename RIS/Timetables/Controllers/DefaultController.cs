using System;
using System.Linq;
using System.Web.Mvc;
using Timetables.Common.Constants;
using Timetables.Common.Data;
using Timetables.Common.Entities;
using Timetables.Common.Enums;
using Timetables.Common.Interfaces;

namespace Timetables.Controllers
{
	public class DefaultController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			var model = DataManager.Instance.DataCollection;
			return View(model);
		}

		[HttpGet]
		public ActionResult Log()
		{
			var model = LogManager.Instance.LogMessages;
			return View(model);
		}

		[HttpGet]
		public ActionResult ImportExport()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Import(FormCollection formCollection)
		{
			if (formCollection.Count > 0 && Request.Files.Count > 0)
			{
				FileTypes fileFormat;
				var sFileFormat = formCollection.Get("fileFormat");
				var fileContents = Request.Files.Get("fileContents");
				if (!string.IsNullOrWhiteSpace(sFileFormat) && Enum.TryParse(sFileFormat, out fileFormat) && fileContents != null)
				{
					DataManager.Instance.LoadFromFile(fileFormat, fileContents.InputStream);
				}
			}
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult Export(FileTypes exportFormat)
		{
			byte[] fileContents;
			string charset;
			DataManager.Instance.SaveToFile(exportFormat, out fileContents, out charset);
			Response.AddHeader("Content-Disposition", "inline; filename=result" + ImportExportFormats.GetExtension(exportFormat));
			Response.Charset = charset;
			return new FileContentResult(fileContents, ImportExportFormats.GetMime(exportFormat));
		}

		[HttpGet]
		public ActionResult Add(TimetableTypes type)
		{
			var model = TimetableFactory.CreateInstance(type);
			return View(model);
		}

		[HttpPost]
		public ActionResult Add(ITimetable instance)
		{
			if (!ModelState.IsValid)
				return View(instance);

			DataManager.Instance.Add(instance);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult Edit(Guid id)
		{
			var model = DataManager.Instance.DataCollection.SingleOrDefault(x => x.Id == id);
			return View(model);
		}

		[HttpPost]
		public ActionResult Edit(Guid id, ITimetable instance)
		{
			if (!ModelState.IsValid)
				return View(instance);

			DataManager.Instance.Edit(id, instance);
			return RedirectToAction("Index");
		}
	}
}
