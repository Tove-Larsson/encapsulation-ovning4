using Encapsulation_ovning4.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Encapsulation_ovning4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//SOLUTION 1:  Sort persons by Name and Age

			//var lines = 5;
			//var persons = new List<Person>();

			//for (int i = 0; i < lines; i++)
			//{
			//	var cmdArgs = Console.ReadLine().Split();
			//	var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
			//	persons.Add(person);
			//}

			//persons.OrderBy(p => p.FirstName)
			//	.ThenBy(p => p.Age)
			//	.ToList()
			//	.ForEach(p => Console.WriteLine(p.ToString()));


			// SOLUTION 2: Salary increase 

			var lines = int.Parse(Console.ReadLine());
			var persons = new List<Person>();

			for (int i = 0; i < lines; i++)
			{
				var cmdArgs = Console.ReadLine().Split();

				try
				{
					var person = new Person(
						cmdArgs[0],
						cmdArgs[1],
						int.Parse(cmdArgs[2]),
						decimal.Parse(cmdArgs[3]
					));

					persons.Add(person);
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			var bonus = decimal.Parse(Console.ReadLine());
			persons.ForEach(p => p.IncreaseSalary(bonus));
			persons.ForEach(p => Console.WriteLine(p.ToString()));

		}
	}
}
