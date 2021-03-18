using HRMIS.DataAccess;
using HRMIS.DataContext;
using HRMIS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HRMIS.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private IRepository _repo;
		private readonly DBContext _dBCOntext;
		public HomeController(ILogger<HomeController> logger, IRepository repo)
		{
			_logger = logger;
			_repo = repo;
		}

		public IActionResult Index()
		{
			
			return View();
		}

		public IActionResult ShowLeaveApplicationForm()
		{
			return View();
		}
		public IActionResult ShowEmpData(int Id = 1)
		{
			var empData = _repo.ShowEMployess(Id);

			return View(empData);
		}

		public IActionResult ShowAppliedLeaves()
		{
			var leaveData = _repo.GetAppliedLeaves();

			return View(leaveData);
		}


		public IActionResult SaveAppliedLeave(int EmpId, DateTime dateFrom, DateTime dateTo, string leaveType, int daysApplied)
		{
			var leaves = _repo.SaveAppliedLeave(EmpId, dateFrom, dateTo, leaveType, daysApplied);
			return View("Index");
		}

		public IActionResult CheckInOut()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
