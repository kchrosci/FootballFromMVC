using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballApplicationForm.Controllers
{
	public class MainController : Controller
	{
		// GET: Main
		public ViewResult Index()
		{
			string time = DateTime.Now.ToString();
			ViewBag.Time = time;
			return View();
		}
	}
}