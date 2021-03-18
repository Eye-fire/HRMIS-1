using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMIS.Models.AppClasses
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string JobTitle { get; set; }
		public bool HasLeavedays { get; set; }
		public int LeaveDays { get; set; }
		public int DaysApplied { get; set; }
		public int DaysRemaining { get; set; }
		



	}
}
