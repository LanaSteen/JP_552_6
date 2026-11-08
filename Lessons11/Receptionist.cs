using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11
{
	internal class Receptionist : Employee
	{

		public int RegisteredPatients { get; set; }

		public void PerformDuty()
		{
			Console.WriteLine($" {FullName} is registering patients.");
		}

		public decimal CalculateBonus()
		{
			return Sallary * RegisteredPatients;
		}


	}
}
