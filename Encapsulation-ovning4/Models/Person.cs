using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_ovning4.Models
{
	internal class Person
	{
		private string _firstName;
		private string _lastName;
		private int _age;


		public override string ToString()
		{
			return $"{_firstName} {_lastName} {_age}";
		}
	}
}
