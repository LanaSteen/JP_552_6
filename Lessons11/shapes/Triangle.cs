using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11.shapes
{
	internal class Triangle : Shape
	{

		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }
		public double Height { get; set; }
		public double Base { get; set; }
		public override double GetArea()
		{
			return 0.5 * Base * Height;
		}
		public override double GetPerimeter()
		{
			return A+B+C;
		}
	
	}
}
