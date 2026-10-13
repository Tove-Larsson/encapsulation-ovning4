using Encapsulation_ovning4.Models;
using Encapsulation_ovning4.Utilities;
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

			var lines = ConsoleInput.ReadInt("How many persons do you want to enter?\n", 1);
			var persons = new List<Person>();

			Console.WriteLine("\nEnter each person on a separate line.");
			Console.WriteLine("Format: FirstName LastName Age Salary\n");

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

			var bonus = ConsoleInput.ReadDecimal("Enter salary bonus percentage (e.g. 20): ");
			persons.ForEach(p => p.IncreaseSalary(bonus));

			Console.WriteLine("\n--- Salary report ---\n");
			persons.ForEach(p => Console.WriteLine(p.ToString()));

		}
	}
}
