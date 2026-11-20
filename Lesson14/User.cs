using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson14
{
	internal class User
	{
		public string Name { get; set; }

		public override bool Equals(object? obj)
		{
			
			//return obj is User user && Name == user.Name;

			var user = obj as User;

			return Name == user.Name;
		}
	}
}
