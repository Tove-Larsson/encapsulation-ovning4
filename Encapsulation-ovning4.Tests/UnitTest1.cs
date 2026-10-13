using Encapsulation_ovning4.Models;
using Xunit;

namespace Encapsulation_ovning4.Tests
{
	public class PersonTests
	{
		[Fact(DisplayName = "A person with valid values is created correctly")]
		public void Constructor_ValidValues_SetsPropertiesCorrectly()
		{
			Person person = new Person("Arathorn", "son of Arathorn", 20, 589.00m);

			Assert.Equal("Arathorn", person.FirstName);
			Assert.Equal("son of Arathorn", person.LastName);
			Assert.Equal(20, person.Age);
			Assert.Equal(589.00m, person.Salary);
		}


		[Theory(DisplayName = "Invalid ages throw exception")]
		[InlineData(0)]
		[InlineData(-1)]
		public void Constructor_InvalidAge_ThrowsException(int age)
		{
			void CreatePerson()
			{
				new Person("Anna", "Andersson", age, 600m);
			}

			var exception = Assert.Throws<ArgumentException>(CreatePerson);

			Assert.Equal(
				"Age cannot be zero or a negative integer!",
				exception.Message);
		}


		[Fact(DisplayName = "Invalid first name throws exception")]
		public void Constructor_InvalidFirstName_ThrowsException()
		{
			void CreatePerson()
			{
				new Person("Al", "Andersson", 25, 600m);
			}

			var exception = Assert.Throws<ArgumentException>(CreatePerson);

			Assert.Equal(
				"First name cannot contain fewer than 3 symbols!",
				exception.Message);
		}


		[Fact(DisplayName = "Invalid last name throws exception")]
		public void Constructor_InvalidLastName_ThrowsException()
		{
			void CreatePerson()
			{
				new Person("Anna", "Li", 25, 600m);
			}

			var exception = Assert.Throws<ArgumentException>(CreatePerson);

			Assert.Equal(
				"Last name cannot contain fewer than 3 symbols!",
				exception.Message);
		}


		[Fact(DisplayName = "Salary below 460 dollars throws exception")]
		public void Constructor_SalaryBelowMinimum_ThrowsException()
		{
			void CreatePerson()
			{
				new Person("Anna", "Andersson", 25, 459m);
			}

			var exception = Assert.Throws<ArgumentException>(CreatePerson);

			Assert.Equal(
				"Salary cannot be less than 460 dollars!",
				exception.Message);
		}


		[Fact(DisplayName = "A person under 30 receives half the salary increase")]
		public void IncreaseSalary_Under30_GetsHalfIncrease()
		{
			Person person = new Person("Bert", "Andersson", 27, 600m);

			person.IncreaseSalary(20m);

			Assert.Equal(660m, person.Salary);
		}
	}
}