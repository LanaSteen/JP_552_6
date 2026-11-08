using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11
{
	internal abstract class Person
	{

		public Person()
		{
		}
		public Person(string fullName)
		{
			FullName = fullName;
		}

		public string FullName { get; set; }
	}
}
