using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11
{
	internal class Nurse : Employee
	{

		public Department Department { get; set; }

		public void PerformDuty()
		{
			Console.WriteLine($" {FullName} working in {Department}");
		}

		public decimal CalculateBonus(decimal rate)
		{
			return Sallary * rate;
		}

	}
}



public enum Department
{
	Emergency,
	Surgery,
	Pediatrics,
	Cardiology,
	Neurology
}