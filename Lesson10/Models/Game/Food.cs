 using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.Models.Game
{
	internal class Food : Sprite, IEatable
	{


		private int myVar;

		public int MyProperty
		{
			get { return myVar; }
			set { myVar = value; }
		}


		public void Die()
		{
			Console.WriteLine("I am dying.");

		}
	}
}
