using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson5
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region hw
			//			1.შექმენით რიცხვების არაი და დათვალეთ რიცხვების საშუალო არითმეტიკული.
			//2.შექმენით რიცხვების jagged array სამი განზომილებით და იპოვეთ ყველაზე დიდი რიცხვი თითოეული განზომილებიდან.
			//3.შექმენით რიცხვების jagged array და დათვალეთ ყველა რიცხვის საშუალო არითმეტიკული.
			//
			//
			// string[] saxeli = ["Alice", "Bob", "Charlie"];
			//    int[] numbers = [20, 60, 30];


			//int sum = 0;
			//foreach (var num in numbers)
			//{
			//	sum += num;
			//}

			//Console.WriteLine(sum / numbers.Length);

			//int[] nums = []; // 0
			////nums[0] = 50;

			//Array.Resize(ref nums, nums.Length+1);  // 1
			//										//
			//nums[0] = 100;

			//int[] x = { 20, 0, 30 };   // []
			//						   //
			//						   //
			//int[] y = new int[5]; // [0,0,0,0,0]




			//2.შექმენით რიცხვების jagged array სამი განზომილებით
			//და იპოვეთ ყველაზე დიდი რიცხვი თითოეული განზომილებიდან.


			//int[][] jagged = 
			//	[
			//	  [20,30,60,15],
			//	  [40,60,78],
			//	  [12,15,65]

			//	];

			//for (int i = 0; i < jagged.Length; i++)
			//{
			//	int max = jagged[i][0]; //40 //     [40,60,78],
			//	for (int j = 1; j < jagged[i].Length; j++)
			//	{
			//		if (jagged[i][j] > max)
			//		{
			//			max = jagged[i][j];
			//		}
			//	}
			//	Console.WriteLine(max);
			//}




			//3.შექმენით რიცხვების jagged array და დათვალეთ ყველა
			//რიცხვის საშუალო არითმეტიკული.
			//
			//int[][] jagged2 = 
			//	[
			//		[15,20,30,45],
			//		[20,30,60],
			//		[78,95,32],
			//		[12,65,32,78]
			//	];


			//int sum = 0;
			//int count = 0;

			//foreach (var arr in jagged2)
			//{
			//	foreach (var el in arr)
			//	{
			//		sum += el;
			//		count++;
			//	}
			//}

			//double avg = sum / count;
			//Console.WriteLine(avg);



			#endregion




			//int[,] a = 
			//{ 

			//	{ 1, 2 }, 
			//	{ 3, 4 }, 
			//	{ 20,30} 

			//};

			//Console.WriteLine(a[0,0]);


			//foreach (var item in a)
			//{
			//	Console.WriteLine(item);
			//}







			///   jagged array სახელები 
			///   უნდა დაბეჭდოთ ყველა სიმბოლო გადაყვანილი მაღალ რეგისტრში
			///   


			string[][] names =
				[
				  ["saxeli1","saxeli2"],
				  ["saxeli3", "Saxeli4"]

				];


			foreach (var arr in names)
			{
				foreach (var saxeli in arr)
				{
					
					foreach (var item in saxeli.ToUpper())
					{
						//Console.WriteLine(item.ToString().ToUpper());
						Console.WriteLine(item);
					}
				}
			}

			//string name = "   ds dsd     ";
			//Console.WriteLine(name.ToUpper());
			//Console.WriteLine(name.ToLower());
			//Console.WriteLine(name.Trim());
			//Console.WriteLine(name.TrimEnd());

			//Console.WriteLine(name.Length);



		}
	}
}
