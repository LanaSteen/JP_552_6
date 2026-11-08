using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11.shapes
{
	internal class Rectangle : Shape
	{

		public double  Withd { get; set; }
		public double Height { get; set; }

		public override double GetArea()
		{
			return Withd * Height;
		}

		public override double GetPerimeter()
		{
			return 2 * (Withd + Height);
		}
	}
}
