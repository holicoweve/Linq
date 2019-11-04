using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;
using Linq.Repositories;

namespace Linq
{
	class Program
	{
		static void Main(string[] args)
		{
			var sample = new SampleQuery(new EmployeeRepository().GetAllPersons());
			var minimumWage = 23100;
			var minimumAge = 16;

			Console.WriteLine($"Department 1 total monthly salary:{sample.TotalSalaryInDepartment1()}");
			Console.WriteLine($"Average tenure in Department 1: {sample.AverageTenureInDepartment1()}");
			Console.WriteLine($"Company comply with minimum wage law of $23100:{sample.CompanyComplyWithMinimumWage(minimumWage)}");
			Console.WriteLine($"Departments that violate the minimum age law of 16: {sample.DepartmentViolateAgeLaw(minimumAge).Aggregate(string.Empty,(s,i)=>s+=" "+i)}");
			Console.ReadKey();
		}
	}

	public class SampleQuery
	{
		private readonly IEnumerable<Employee> _employees;

		public SampleQuery(IEnumerable<Employee> employees)
		{
			_employees = employees;
		}

		public int TotalSalaryInDepartment1()
		{
			throw new NotImplementedException();
		}

		public double AverageTenureInDepartment1()
		{
			throw new NotImplementedException();
		}

		public bool CompanyComplyWithMinimumWage(int minimumWage)
		{
			throw new NotImplementedException();
		}

		public List<int> DepartmentViolateAgeLaw(int minimumAge)
		{
			throw new NotImplementedException();
		}
	}
}
