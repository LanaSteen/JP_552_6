using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11
{
	internal class Nurse : Employee, ICrazy
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

		public void Jumping()
		{
			Console.WriteLine("cliff jumping ");
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