using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12
{
	internal class Player : IComparable<Player>
	{
		public Player(string name, int sore)
		{
			Name = name;
			Sore = sore;
		}

		public string Name { get; set; }
		public int Sore { get; set; }

		public int CompareTo(Player? other)
		{
			return  this.Sore.CompareTo(other.Sore);
		}
	}
}
