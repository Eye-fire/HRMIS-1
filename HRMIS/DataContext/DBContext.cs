using HRMIS.Models.AppClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMIS.DataContext
{
	public class DBContext : DbContext
	{
		public DBContext()
		{
		}

		public DBContext(DbContextOptions<DBContext> options)
		: base(options)
		{
		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Leave> Leaves { get; set; }
		public DbSet<AppliedLeaves> AppliedLeaves { get; set; }
		public DbSet<CheckInOut> CheckInOuts { get; set; }
	}
}
