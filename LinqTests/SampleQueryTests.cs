using Linq;
using Linq.Repositories;
using NUnit.Framework;

namespace LinqTests
{
	public class SampleQueryTests
	{
		private SampleQuery _sample;

		[SetUp]
		public void Setup()
		{
			_sample = new SampleQuery(new EmployeeRepository().GetAllPersons());
		}

		[Test]
		public void TotalSalaryInDepartment1IsCorrect()
		{
			var expected = 135000;
			var actual = _sample.TotalSalaryInDepartment1();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void AverageTenureInDepartment1IsCorrect()
		{
			var expected = 3;
			var actual = _sample.AverageTenureInDepartment1();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void CompanyComplyWithMinimumWage23100IsCorrect()
		{
			var actual = _sample.CompanyComplyWithMinimumWage(23100);
			Assert.IsFalse(actual);
		}

		[Test]
		public void DepartmentViolateAgeLaw16IsCorrect()
		{
			var expected = new[] { 2, 3 };
			var actual =_sample.DepartmentViolateAgeLaw(16);
			
			CollectionAssert.AreEquivalent(expected,actual);
		}
	}
}