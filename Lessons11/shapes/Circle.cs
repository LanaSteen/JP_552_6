using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11.shapes
{
	internal class Circle : Shape
	{
		public double R { get; set; }
		public const double Pi  = 3.14;

		public override double GetArea()
		{
			return Pi * R * R;
		}

		public override double GetPerimeter()
		{
			return 2 * Pi * R;
		}
	}
}
