using System.Collections.Generic;
using Linq.Models;

namespace Linq.Repositories
{
	public class EmployeeRepository
	{
		private readonly List<Employee> _persons;

		public EmployeeRepository()
		{
			_persons = new List<Employee>
			{
				new Employee
				{
					Age = 25,
					Name = "John",
					DepartmentId = 1,
					Tenure = 5,
					MonthlySalary = 50000
				},
				new Employee()
				{
					Age = 35,
					Name = "David",
					DepartmentId = 1,
					Tenure = 1,
					MonthlySalary = 40000
				},
				new Employee
				{
					Name = "Mary",
					Age = 30,
					DepartmentId = 1,
					MonthlySalary = 45000,
					Tenure = 3
				},
				new Employee
				{
					Name = "Alex",
					Age = 10,
					DepartmentId = 2,
					MonthlySalary = 20000,
					Tenure = 2
				},
				new Employee
				{
					Name = "Bob",
					Age = 12,
					DepartmentId = 3,
					MonthlySalary = 24000,
					Tenure = 1
				}
			};
		}
		public IEnumerable<Employee> GetAllPersons()
		{
			return _persons;
		}
	}
}