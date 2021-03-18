using Dapper;
using HRMIS.DataContext;
using HRMIS.Models.AppClasses;
using HRMIS.Models.DBConn;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HRMIS.DataAccess
{
	public class Repository : IRepository
	{
		private readonly DBContext _dBCOntext;
		IDbConnection _dbcon = DbCon.Connection();
		private readonly IConfiguration _config;

		public Repository(DBContext dBContext, IConfiguration config)
		{
			_dBCOntext = dBContext;
			_config = config;
		}
		public IEnumerable<Employee> ShowEMployess(int Id)
		{
			var emps = _dBCOntext.Employees.ToList();

			return emps;
		}

		public int SaveAppliedLeave(int EmpId,DateTime dateFrom, DateTime dateTo, string leaveType, int daysApplied)
		{
			SqlConnection con = new SqlConnection(GetConString.ConString());

			string query = "INSERT INTO APPLIEDLEAVES(LeaveType, DateFrom, DateTo, LeaveDays) values ('" + leaveType + "', '" + dateFrom + "', '" + dateTo + "', '" + daysApplied + "')";

			SqlCommand cmd = new SqlCommand(query, con);
			con.Open();

			var results = cmd.ExecuteNonQuery();

			con.Close();

			return results;

		}

		public IEnumerable<AppliedLeaves> GetAppliedLeaves()
		{
			var appliedLeaves = _dBCOntext.AppliedLeaves.ToList();

			return appliedLeaves;
		}

		public IEnumerable<AppliedLeaves> GetAppliedLeaves(int Id)
		{
			var appliedLeaves = _dBCOntext.AppliedLeaves.Where(l => l.EmpId == Id).ToList();

			return appliedLeaves;
		}

		public IEnumerable<CheckInOut> GetHours()
		{
			throw new NotImplementedException();
		}
	}
}
