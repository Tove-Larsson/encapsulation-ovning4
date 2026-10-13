using System;

namespace Encapsulation_ovning4.Utilities
{
	internal class ConsoleInput
	{
		public static int ReadInt(string prompt, int minValue)
		{
			while (true)
			{
				Console.Write(prompt);
				string? input = Console.ReadLine();

				if (int.TryParse(input, out int result) && result >= minValue)
				{
					return result;
				}

				Console.WriteLine($"Please enter a valid integer of at least {minValue}.");
			}
		}

		public static decimal ReadDecimal(string prompt)
		{
			while (true)
			{
				Console.Write(prompt);
				string? input = Console.ReadLine();

				if (decimal.TryParse(input, out decimal result) && result >= 0)
				{
					return result;
				}

				Console.WriteLine("Invalid input or negative bonus percentage.");
			}
		}
	}
}
