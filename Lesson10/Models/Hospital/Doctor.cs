using Lesson10.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.Models.Hospital
{
	internal class Doctor 
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public Specialization Specialization { get; set; }///  todo  
		public string[] Pictures { get; set; }
		public decimal[] Bonuses { get; set; }
		public Patient[] Patient { get; set; }
		public Account Account { get; set; }

		public override string? ToString()
		{
			return $"{Name} {Surname} - {Specialization}";
		}
	}


	public enum Specialization
	{
		Cardiologist,
		Dermatologist,
		Neurologist,
		Pediatrician,
		Psychiatrist,
		Radiologist,
		Surgeon
	}
}

