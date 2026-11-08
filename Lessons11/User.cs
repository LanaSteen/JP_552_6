using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11
{
	internal class User : Person
	{
		public User()
		{
		}

		public User(int id)
		{
			Id = id;
		}

		//public User(string name)
		//{
		//	Name = name;
		//}

		public User(string name, string password)
		{
			Name = name;
			Password = password;
		}





		public User(int id, string name, string password)
		{
			Id = id;
			Name = name;
			Password = password;
		}

		public User(string fullName) : base(fullName)
		{
		}

		public void PrntUer(string name)
		{
			Console.WriteLine(name);
		}
		public void PrntUer(string name, string password)
		{
			Console.WriteLine(name);
			Console.WriteLine(password);
		}


		public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
	}
}

//overrride 
	//overload - გადატვირთვა