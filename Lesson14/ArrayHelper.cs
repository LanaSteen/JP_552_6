using System;
using System.Collections.Generic;
using System.Text;


//this  - extention method


//delegate  call back =>  find(x=>x.Id==1)

                        //map(x=> Number(x))

//Func  =  ნებისმიერი ტიპი
//Predicate  = bool
//Action = void




namespace Lesson14
{
	internal static class ArrayHelper
	{

		public static void PrintAll<T>(this T[] arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}

		//public static void PrintReverse<T>(this T[] arr) 
		//{
		//	for (int i = arr.Length - 1; i >= 0; i--)
		//	{
		//		Console.WriteLine(arr[i]);
		//	}

		//}

		//public static void PrintReverse<T>(this T[] arr)
		//{
		//	Array.Reverse(arr);
		//	foreach (var item in arr )
		//	{
		//		Console.WriteLine(item);
		//	}

		//}



		//GetFirstElement<T>

		public static T GetFirstElement<T>(this T[] arr) 
		{
			//return arr[0];
			foreach (var item in arr)
			{
				return item;
			}

			return default;
		}


		public static T GetLastElement<T>(this T[] arr)
		{
			//return arr[arr.Length-1];
			T temp = default;

			foreach (var item in arr)
			{
				temp = item;
			}

			return temp;
		}




		//ContainsElement<T>


		public static bool ContainsElement<T>(this T[] arr, T el)
		{

			foreach (var item in arr)
			{
				if (item.Equals(el))
				{
					return true;
				}
			}


			return false;
		}


		//CountElements<T>

		public static int CountElements<T>(this T[] arr)
		{
			int count = 0;
			foreach (var item in arr)
			{
				count++;
			}

			return count;
		}


		//FindIndex<T>

		public static int FindIndex<T>(this T[] arr, T el)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i].Equals(el))
				{
					return i;
				}
			}

			return -1;
		}


		//Swap<T>
		public static T[] Swap<T>(this T[] arr, int ind1, int ind2)
		{
			T temp = arr[ind1];
			arr[ind1] = arr[ind2];
			arr[ind2] = temp;
			return arr; 
		}



		public static T CustomFirstOrDefault<T>(this T[] arr, Predicate<T> pred)
		{
			foreach (var item in arr)
			{
				if (pred(item))
				{
					return item;
				}
			}
			return default;
		}

		public static T CustomLastOrDefault<T>(this T[] arr, Func<T, bool> func)
		{
			T temp = default;
			foreach (var item in arr)
			{
				if (func(item))
				{
					temp = item;
				}
			}
			return temp;
		}



		public static T1[] CustomSelect<T, T1>(this T[] arr, Func<T, T1> func)
		{
			T1[] numbrs = new T1[arr.Length];
			for (int i = 0;	i< arr.Length; i++)
			{
				numbrs[i] = func(arr[i]);
			}

			return numbrs;
		}

	    public static int CustomCount<T>(this T[] arr, Predicate<T> pred)
		{
			int count = 0;
			foreach (var item in arr)
			{
				if (pred(item))
					count++;
			}

			return count;
		}

		//CustomCount   - თუ predicate გადაეცა
		//დათვალო ელემეტები რამდენი აკმაყოფილებს პირობას

	}
}
