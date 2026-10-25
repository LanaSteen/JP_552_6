using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw


			//			დავალება 1
			//შექმენით ერთ განზომილებიანი ორი მასივი.
			//შეავსეთ ორივე მასივი ელემენტებით.
			//გააერთიანე ერთ მასივში ორივე მასივის ელემენტები.
			//დაბეჭდეთ საბოლოოდ მიღებული მასივი.
			//მაგალითად, თუ პირველი მასივის ელემენტების: 1 2 3
			//ხოლო მეორე მასივის ელემენტებია : 4 5 6
			//შედეგად უნდა მიიღოთ: resultArray = [1, 2, 3, 4, 5, 6]
			//
			//
			//int[] num1 = [20, 30, 60];
			//int[] num2 = [54, 65, 98];

			//int[] resultArray = new int[num1.Length+ num2.Length]; //[0,0,0,0,0,0]

			//for (int i = 0; i < num1.Length; i++)
			//{
			//	resultArray[i] = num1[i];
			//}

			//for (int i = 0; i < num2.Length; i++)
			//{
			//	resultArray[num1.Length+ i] = num2[i];
			//}


			//for (int i = 0; i < resultArray.Length; i++)
			//{
			//	resultArray[i] = num1[i];
			//}


			//			დავალება 2
			//შექმენით ინტების მასივი და შეავსეთ ელემენტებით. მაგ: 3, 5, -4, 8, 11, 1, -1, 6



			//კონსოლიდან გადმოეცით რაღაც რიცხვი რომელსაც შეინახავთ targetSum ცვლადში.
			//მოძებნეთ მასივში ყველა ის ორი ელემენტი რომლის ჯამიც იქნება targetSum ტოლი და ამწყვილებისგან შექმენით მასივი.
			//დააბრუნეთ ამ ელემენტების წყვილები კონსოლში.
			//2 | P a g e
			//მაგალითად: array = { 3, 5, -4, 8, 11, 1, -1, 6}
			//			targetSum = 7
			//შედეგად უნდა მივიღოთ: resultArray = [[1, 6], [8, -1], [-4, 11]]

			//int[] nums = [3, 5, -4, 8, 11, 1, -1, 6];
			//int count=0;
			//Console.WriteLine("enter number:");
			//int number = int.Parse(Console.ReadLine());
			//for (int i = 0; i < nums.Length; i++)
			//{
			//	for (int j = 0; j < nums.Length; j++)
			//	{
			//		if (nums[i] + nums[j] == number)
			//		{
			//			count++;

			//		}

			//	}
			//}
			//int[][] result= new int [count][];
			//int index = 0;
			//for (int i = 0; i < nums.Length; i++)
			//{
			//	for (int j = 0; j < nums.Length; j++)
			//	{
			//		if (nums[i] + nums[j] == number)
			//		{
			//			result[index] = [nums[i], nums[j]];
			//			index++;

			//		}

			//	}
			//}

			//foreach (var numbers in result)
			//{

			//	foreach (var item in numbers)
			//	{

			//		Console.Write(item);
			//		Console.Write(" ");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			//ფუნქციები   prompt
			//მეთოდები  console.log


			#region local funqctions
			//string Name(string name) 
			//{

			//	return name.ToUpper();
			//}

			//Console.WriteLine(Name("John"));


			//int Sum(int x, int y)
			//{
			//	return x + y;
			//}

			//int jami = Sum(7,5);  // 12
			//Console.WriteLine(jami);


			//Console.WriteLine(Sum(20,10));

			//bool isValid(string name)
			//{
			//	if(name == null || name == "")
			//	{
			//		return false;
			//	}

			//	return true;
			//}


			//if (isValid("jonhn"))
			//{
			//	Console.WriteLine("sddfg");
			//}

			//void Print()
			//{
			//	Console.WriteLine("hello World");
			//}


			//Print();
			//Print();

			//Print();
			//Print();
			//Print();


			#endregion
			
			
			Random rand = new Random();
			rand.Next(1, 10);

		

			PrintHello();


			//Program prog = new Program();
			//prog.PrintHello();




			Console.WriteLine();




			//შექმენით მეთოდი რომელიც
			//	პარამეტრად მიიღევს რიცხვების მასივს 
			//	და კონსოლში დაბეწდავს
			//	ყველა რიცხვს გამრავლებულს ორზე
			int[] numbers = [20, 30, 50];
			PrintArr(numbers);

		}
		//static

		static void PrintHello()
		{
			Console.WriteLine("Hello");
		}




		static void PrintArr(int[] arr) 
		{

			foreach (var item in arr)
			{
				Console.WriteLine(item*2);
			}
		}

	}
}
