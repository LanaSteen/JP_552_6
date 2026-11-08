using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11.shapes
{
	internal abstract class Shape
	{
		public double Length { get; set; }


		public abstract double GetArea();

		public abstract double GetPerimeter();
	}
}
