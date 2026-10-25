using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
	internal class User
	{
		public string Name;
		public string Surname;
		public int Age;

		public static void Saxeli()
		{
			Console.WriteLine("hello");
			
		}

		public void PrintInfo()
		{
			Console.WriteLine($"{Name} {Surname} {Age}");
		}

		//field
		//property
		//method
	}
}
