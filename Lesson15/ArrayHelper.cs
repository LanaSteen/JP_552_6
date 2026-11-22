using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson15
{
	internal static class ArrayHelper
	{
		//Where


		public static T[] CustomWhere<T>(this T[] arr, Predicate<T> logika)
		{

			T[] newArr = [];   // 50   30   40 
			foreach (var item in arr)
			{
				if (logika(item))
				{
					Array.Resize(ref newArr, newArr.Length + 1);
					newArr[newArr.Length - 1] = item;
				}
			}

			return newArr;




		}




		public static T CustomFirstOrDefault<T>(this T[] arr, Predicate<T> logika)
		{
			foreach (var item in arr)
			{
				if (logika(item))
				{
					return item;
				}
			}

			return default;
		}

		public static T CustomFirst<T>(this T[] arr, Predicate<T> logika)
		{
			foreach (var item in arr)
			{
				if (logika(item))
				{
					return item;
				}
			}

			throw new Exception();
		}


		public static bool CustomAny<T>(this T[] arr, Predicate<T> logika)
		{
			foreach (var item in arr)
			{
				if (logika(item))
				{
					return true;
				}
			}

			return default;
		}

		public static bool CustomAll<T>(this T[] arr, Predicate<T> logika)
		{

			bool all = true;

			foreach (var item in arr)
			{
				if (!logika(item))
				{
					all = false;
				}
			}
			return all;
		}


		public static int CustomCount<T>(this T[] arr, Predicate<T> logika =null)
		{
			int count = 0;
			if(logika == null)
			{
				return arr.Length;
			}
			else
			{
				foreach (var item in arr)
				{
					if (logika(item))
					{
						count++;
					}
				}
				return count;
			}
		}
	}
}
