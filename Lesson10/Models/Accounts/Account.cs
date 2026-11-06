using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.Models.Accounts
{
	internal abstract class Account
	{
		private string _accountNumber;
		public string AccountNumber	 { 
			get { return _accountNumber; } 
			set 
			{
			  if(value.Length != 22)
				{
					Console.WriteLine("error");
				}
				else
				{
					_accountNumber = value;
				}
			}
		}

		private decimal _balace;

		public decimal Balance
		{
			get { return _balace; }
			set { 
			 if(value < 0)
				{
					Console.WriteLine("error");
				}
				else
				{
					_balace = value;
				}
			}
		}

	}
}
