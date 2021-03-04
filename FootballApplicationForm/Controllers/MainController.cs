using FootballApplicationForm.Models;
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
		[HttpGet]
		public ViewResult RegisterPlayer()
		{
			return View();
		}
		[HttpPost]
		public ViewResult RegisterPlayer(PlayerInfo playerInfo)
		{
			return View("Thank you for register!",playerInfo);
		}
	}
}