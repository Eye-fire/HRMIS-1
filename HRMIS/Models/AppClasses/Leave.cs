using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMIS.Models.AppClasses
{
	public class Leave
	{
		[Key]
		public int LeaveId { get; set; }
		public string LeaveType { get; set; }

		//public IEnumerable<AppliedLeaves> AppliedLeaves { get; set; }
	}

	public class AppliedLeaves
	{
		
		[Key]
		public int EmpId { get; set; }
		public string LeaveType { get; set; }
		public DateTime DateFrom { get; set; }
		public DateTime DateTo { get; set; }
		public int LeaveDays { get; set; }
		public string Message { get; set; }

		//public IEnumerable<Employee> Employee { get; set; }
	}
}
