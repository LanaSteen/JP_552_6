using System;
using System.Collections.Generic;
using System.Text;


// ჯენერიკი - ზოგადი 
// extention method  this
namespace Lesson13
{
	internal static class ArrayHelper
	{

		//public static void PrintArray(int[] arr) 
		//{
		//	foreach (var item in arr)
		//	{
		//		Console.WriteLine(item);
		//	}

		//}
		public static void PrintArray<T>(this T[] arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}

		}


		public static X FindelEment<X>(this X[] arr, X el)
		{
			foreach (var item in arr)
			{
				if(item.Equals(el))
				{
					return item;
				}
			}

			return default;
		}

		public static T FindLastOrDefault<T>(this T[] arr, T el)
		{
			T temp = default;

			foreach (var item in arr)
			{
				if (item.Equals(el))
				{
					temp = item;
				}
			}

			return temp;
		}



		public static T[] CustomSwipe<T>(this T[] arr, int ind1, int ind2)
		{
			T temp = arr[ind1];
			arr[ind1] = arr[ind2];
			arr[ind2] = temp;


			return arr;
		}


		public static void FindTwoElOrDefault<T>(this T[] arr, T el, T el2)
		{
		
			T result1 = default;
			T result2 = default;

			foreach (var item in arr)
			{
				if (item.Equals(el) )
				{
					result1 = item;
				}
				if (item.Equals(el2)) 
				{
					result2 = item;
				}
			}



			Console.WriteLine($"{result1} {result2}");
		
		}


	}
}
