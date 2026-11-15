using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13
{
	internal class Student : IComparable<Student>
	{
		public Student(string name, string lasName, int age, double score)
		{
			Name = name;
			LasName = lasName;
			Age = age;
			Score = score;
		}

		public string Name { get; set; }
		public string LasName { get; set; }
		public int Age { get; set; }
		public double Score { get; set; }

		public int CompareTo(Student? other)
		{
			return this.Score.CompareTo(other.Score);
		}

		public override bool Equals(object? obj)
		{
			return obj is Student student &&
				   Name == student.Name &&
				   LasName == student.LasName &&
				   Age == student.Age &&
				   Score == student.Score;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string? ToString()
		{
			return $"Student: {Name} {LasName}, Age: {Age}, Score: {Score}";
		}
	}
}
