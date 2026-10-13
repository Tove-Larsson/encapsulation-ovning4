using System;

namespace Encapsulation_ovning4.Models
{
	internal class Person
	{
		private string _firstName = string.Empty;
		private string _lastName = string.Empty;
		private int _age;

		private decimal _salary;

		public Person(string firstName, string lastName, int age, decimal salary)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Salary = salary;
		}

		public string FirstName
		{
			get { return _firstName; }
			set
			{
				if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
				{
					throw new ArgumentException(
						"First name cannot contain fewer than 3 symbols!");
				}
				_firstName = value;
			}
		}
		public string LastName 
		{ 
			get { return _lastName; }
			set
			{
				if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
				{
					throw new ArgumentException(
						"Last name cannot contain fewer than 3 symbols!");
				}
				_lastName = value;
			}
		}

		public int Age 
		{ 
			get { return _age; }
			set
			{

				if (value <= 0)
				{
					throw new ArgumentException(
						"Age cannot be zero or a negative integer!");
				}

				_age = value;
			}
		}

		public decimal Salary
		{
			get { return _salary; }
			set
			{

				if (value < 460)
				{
					throw new ArgumentException(
						"Salary cannot be less than 460 dollars!");
				}

				_salary = value;
			}
		}


		// SOLUTION 1 ToString: Sort persons by Name and Age

		//public override string ToString()
		//{
		//	return $"{FirstName} {LastName} is {Age} years old.";
		//}


		//SOLUTION 2 ToString: Salary increase 
		public override string ToString()
		{
			return $"{FirstName} {LastName} receives {Salary:F2} dollars.";

		}
		public void IncreaseSalary(decimal percentage)
		{
			if (Age < 30)
			{
				percentage = percentage / 2;
			}

			decimal increasedSalary = Salary * percentage / 100;

			Salary = Salary + increasedSalary;

		}
	}
}
