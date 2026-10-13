using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_ovning4.Models
{
	internal class Person
	{
		private string _firstName = string.Empty;
		private string _lastName = string.Empty;
		private int _age;

		public Person(string firstName, string lastName, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public string FirstName
		{
			get { return _firstName; }
			set
			{
				_firstName = value;
			}
		}
		public string LastName 
		{ 
			get { return _lastName; }
			set
			{
				_lastName = value;
			}
		}

		public int Age 
		{ 
			get { return _age; }
			set
			{
				_age = value;
			}
		}


		public override string ToString()
		{
			return $"{FirstName} {LastName} {Age}";
		}
	}
}
