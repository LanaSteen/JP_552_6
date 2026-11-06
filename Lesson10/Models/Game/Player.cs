using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.Models.Game
{
	internal class Player : Sprite, IDamagable, IEatable
	{
		public void Attack(int damage)
		{
			Console.WriteLine("I am attacking with " + damage + " damage.");
		
		}

		public void TakeDamage(int damage)
		{
			Console.WriteLine("I am taking " + damage + " damage.");
	
		}

		public void Die()
		{
			Console.WriteLine("I am dying. But I will return!");

		}
	}
}
