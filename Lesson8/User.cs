using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson8
{
	internal class User
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set 
			{
			   if(value == null)
				{
					Console.WriteLine("eerror");
				}
				else
				{
					_name = value;
				}
			
			
			}
		}

		private byte _age;

		public byte Age
		{
			get { return _age; }
			set 
			{ 
			   if( value > 120)
				{
					Console.WriteLine("eerror");
				}
				else
				{
					_age = value;
				}
			}
		}



		private string _email;

		public string Email
		{
			get { return _email; }
			set 
			{
			   if(value == null || !value.Contains("@"))
				{
					Console.WriteLine("eerror");
				}
				else
				{
					_email = value;
				}
			}
		}



		private string _password;

		public string Password
		{
			get { return _password; }
			set {
				if(value == null || value.Length < 8 || Regex.IsMatch(value, "[a-z]") == false|| Regex.IsMatch(value, "[A-Z]") == false || Regex.IsMatch(value, "[A-Z]") == false || Regex.IsMatch(value, "[0-9]") == false)
				{
					Console.WriteLine("eerror");
				}
				else
				{
					_password = value;
				}		
			}
		}


		private string _phone;

		public string Phone
		{
			get { return _phone; }
			set 
			{
				if (value.Length != 9)
				{
					Console.WriteLine("eerror");
				}
				else
				{
					_phone = value;
				}
			}
		}

		public override string? ToString()
		{
			return $"{Phone} {Name} {Age} {Email} {Password}";
		}
	}
}
