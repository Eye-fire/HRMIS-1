using HRMIS.Models.AppClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMIS.DataAccess
{
	public interface IRepository
	{
		IEnumerable<Employee> ShowEMployess(int Id);

		int SaveAppliedLeave(int EmpId, DateTime from, DateTime to, string type, int days);

		IEnumerable<AppliedLeaves> GetAppliedLeaves();

		IEnumerable<AppliedLeaves> GetAppliedLeaves(int Id);

		IEnumerable<CheckInOut> GetHours();
	}
}

