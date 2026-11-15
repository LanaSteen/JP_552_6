namespace Lesson13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student[] students =
			{
				new Student ("saxeli1", "gvari1", 20, 95),
				new Student ("saxeli2", "gvari2", 21, 80),
				new Student ("saxeli3", "gvari3", 19, 90),
				new Student ("saxeli4", "gvari4", 18, 50),
				new Student ("saxeli5", "gvari5", 22, 70),

			};
			//Array.Sort(students);
			//foreach (var item in students)
			//{
			//	foreach (var item1 in students)
			//	{
			//		if (item.Equals(item1)	)
			//		{
			//			Console.WriteLine(item);
			//		}
			//	}
			//}

			int[] nunmber = [20, 30, 603, 20]; //20

			ArrayHelper.PrintArray(nunmber);

			nunmber.PrintArray();


			string[] names = ["John", "James"];
			ArrayHelper.PrintArray(names);



			ArrayHelper.PrintArray(students);


			Console.WriteLine(names.FindelEment("Jane"));







			

		}
	}
}
