using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11
{
	internal class Doctor : Employee, ICrazy
	{

		public Specialization Specialization { get; set; }


		public void PerformDuty()
		{
			Console.WriteLine($" {FullName} working as a {Specialization}.");
		}


		public decimal	CalculateBonus(int patientCount)
		{
			return Sallary * patientCount;
		}

		public void Jumping()
		{
			Console.WriteLine("I am jumping!`");
		}


		public override void Rame()
		{
			Console.WriteLine("Rame from doctor");
		}
	}
}





public enum Specialization
{
	Cardiologist,
	Dentist,
	Neurologist,
	Pediatrician,
	Surgeon
}