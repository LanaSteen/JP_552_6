using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11
{
	internal abstract class Employee
	{
		public string FullName { get; set; }
		private decimal _sallary;

		public decimal Sallary
		{
			get { return _sallary; }
			set { 
			
			  if(value <= 0)
				{
					Console.WriteLine("error: salary must be positive");
				}
				else
				{
					_sallary = value;
				}
			
			}
		}

		public abstract void Jumping();

		public virtual void Rame() 
		{
			Console.WriteLine("Working");
		
		}




		public void ShowInfo()
		{
			Console.WriteLine($"Full name: {FullName}, Sallary: {Sallary}");
		}

		public void	PerformDuty()
		{
			Console.WriteLine($" {FullName} working.");
		}

		public decimal CalculateBonus(decimal rate)
		{
			return Sallary * rate;
		}
	}
}
