using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.Models.Game
{
	internal interface IDamagable
	{
		public void TakeDamage(int damage);
		public void Attack(int damage);
	}
}
