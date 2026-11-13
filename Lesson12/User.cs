using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Lesson12
{
	internal class User 
	{
		public User( string name, string password)
		{
	
			Name = name;
			Password = password;
		}


		public string Name { get; set; }
		public string  Password { get; set; }

		public override bool Equals(object? obj)
		{
			return obj is User user 
				&& this.Name == user.Name 
				&& this.Password == user.Password;
		}

		public override int GetHashCode()  /// 13456465879
		{
			return base.GetHashCode();
		}
	}
}
