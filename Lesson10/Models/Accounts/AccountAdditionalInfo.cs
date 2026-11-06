using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.Models.Accounts
{
	internal class AccountAdditionalInfo : Account
	{
		private string _cardNumber;

		public string CardNumber
		{
			get { return _cardNumber; }
			set { 
			   if(value.Length != 16)
				{
					Console.WriteLine("error");
				}
				else
				{
					_cardNumber = value;
				}

			}
		}


		private DateTime _expDate;

		public DateTime ExpDate
		{
			get { return _expDate; }
			set { 
			    if(value < DateTime.Now)
				{
					Console.WriteLine("error");
				}
				else
				{
					_expDate = value;

				}}
		}

	}
}
