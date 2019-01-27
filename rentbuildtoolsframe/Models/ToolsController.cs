using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rentbuildtoolsframe.Models;
using rentbuildtoolsframe.ViewModels;

namespace rentbuildtoolsframe.Models
{
	public class ToolsController : Controller
	{
		// GET: Tools
		public ActionResult Random()
		{
			var tool = new Tool() { Name = "Перфоратор" };
			//ViewData["RandomTool"] = tool;
			//ViewBag.Tool = tool;
			var customers = new List<Customer>
			{
				new Customer{ Name = "Customer 1"},
				new Customer{ Name = "Customer 2"}
			};
			var viewModel = new RandomToolViewModel
			{
				Tool = tool,
				Customers = customers
			};
			var viewResult = new ViewResult();
			//viewResult.ViewData.Model;
			return View(viewModel);
			//return Content("Арендовать перфоратор");
			//return new ViewResult();
			//return RedirectToAction("Index","Home", new { page=1, sortBy = "name"});
		}
		public ActionResult Edit(int id)
		{
			return Content("id=" + id);

		}
		public ActionResult Index(int? pageIndex, string sortBy)
		{
			if (!pageIndex.HasValue)
			{
				pageIndex = 1;
			}
			if (String.IsNullOrWhiteSpace(sortBy))
			{
				sortBy = "Name";
			}
			return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
		}
		[Route("tools/rentday/{year:regex(\\d{4}):range(2001,2100)}/{month:regex(\\d{2}):range(1,12)}/{day:regex(\\d{2}):range(1,31)}")]
		public ActionResult ByRentDate(int year, int month, int day)
		{
			return Content(year + "/" + month + "/" + day);
		}
	}
}