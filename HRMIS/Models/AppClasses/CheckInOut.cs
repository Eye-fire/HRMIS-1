using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMIS.Models.AppClasses
{
	public class CheckInOut
	{
		[Key]
		public int EmpId { get; set; }
		public DateTime TimeIn { get; set; }
		public DateTime TimeOut { get; set; }
		public int Hours { get; set; }
	}
}
