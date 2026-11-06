using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.Models.Accounts
{
	internal class CurrentAccount : Account
	{
		private decimal _overdrfaftLimit;

		public decimal OverdraftLimit
		{
			get { return _overdrfaftLimit; }
			set { 
			
			   if(value < 0)
				{
					Console.WriteLine("error");
				}
				else
				{
					_overdrfaftLimit = value;
				}
			}
		}

	}
}
