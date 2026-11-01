using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
	internal class Person
	{
		private string _name;  ///  shemnaxveli

		public string Name
		{
			get { return _name; }
			set
			{
				if (value == null)
				{
					Console.WriteLine("error");
				}
				else
				{
					_name = value;
				}

			}
		}

		private string _surname;

		public string Surname
		{
			get { return _surname; }
			set
			{
				if (value == null || string.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("error");
				}
				else
				{
					_surname = value;
				}

			}
		}


		private byte _age;

		public byte Age
		{
			get { return _age; }
			set
			{
				if (value > 100)
				{
					Console.WriteLine("error");
				}
				else
				{
					_age = value;
				}
			}
		}


	
	}
}
