using System;
using System.Collections.Generic;
using System.Text;




// o o p 
	//1. ინკაფსულაცია
	//2. მემკვიდრეობა
	//3. პოლიმორფიზმი
	    //4. აბსტრაქცია

namespace Lesson8
{
	internal class Product 
	{
		//public string Title { get; set; } // property ""

		private string _title;

		public string Title
		{
			get { return _title; }
			set 
			{  
			if(value == "" || string.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("Error");
				}

				else
				{
					_title = value;
				}
			
			
			}
		}


		public int Amount { get; set; }

		private double _rating; ///  შემნახველი 5

		public double Rating  /// გამტარი
		{
			get { return _rating; }
			set { 
			   if(value  < 0 || value > 5) //6
				{
					Console.WriteLine("Error");
				}
			else
				{
					_rating = value;
				}
			
			
			}
		}




		//fullproperty  
		//private ცვლადი და public ფროფერტთის გაერთიანება






		//public string Title { get; 
		//	set 
		//	{ 

		//		if(value.Length < 2)
		//		{
		//			Console.WriteLine("Error");
		//		}


		//	} 

		//}

		//public string Title;
		public string Description; // feild
		public decimal Price;


		public void ConvertToGel()
		{
			Console.WriteLine(Price * 2.6m);
		}

		public void Print()
		{
			Console.WriteLine($"Title: {Title}, Description: {Description}, Price: {Price}");
		}


		// override   - გადაწერა / გადაკეთება
		public override string? ToString()
		{
			return $"Title: {Title}, Description: {Description}, Price: {Price}";
		}
	}
}
