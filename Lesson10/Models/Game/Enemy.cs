using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.Models.Game
{
	internal class Enemy : Sprite, IDamagable
	{
		public void Attack(int damage)
		{
			Console.WriteLine("I am attacking with " + damage + " damage.");

		}

		public void TakeDamage(int damage)
		{
			Console.WriteLine("I am taking " + damage + " damage.");

		}
	}
}
