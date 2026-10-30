namespace Lesson7
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region

			//void Saxeli(string x)
			//{
			//	Console.WriteLine(x);
			//}
			//Saxeli("hi");



			//int Sum(int x, int y)
			//{
			//	return x + y;
			//}


			//int jami = Sum(7, 5);  // 12

			//Console.WriteLine(jami);


			//bool IsGreater(int x, int y)
			//{
			//	return x > y;
			//}

			//bool rame = IsGreater(10, 5);  // true



			//string GetUpper(string x)
			//{
			//	return x.ToLower();
			//}


			//string upper = GetUpper("hello");  // "hello"




			//Random random = new Random();
			//random.Next();




			//Console.WriteLine();

			//PrintHello();


			#endregion

			#region hw 1

			//Console.WriteLine("Enter Point 1:");
			//int point1 = int.Parse(Console.ReadLine());

			//Console.WriteLine("Enter Point 2:");
			//int point2 = int.Parse(Console.ReadLine());


			//Console.WriteLine("Enter Point 3:");
			//int point3 = int.Parse(Console.ReadLine());

			//double average = CalculateAverage(point1, point2, point3);
			//Console.WriteLine(average);



			//Console.WriteLine(GetGrade(point1) + " " + GetGrade(point2));

			//Console.WriteLine(GetGrade(point3));
			//Console.WriteLine(IsPassed(point3));




			//bool IsValidScore(int x)
			//{
			//	return x >= 0 && x <= 100;
			//}
			//Console.WriteLine(IsValidScore(point1));

			#endregion hw1


			#region hw 2
			//IsEven(6);



			//bool IsPositive(int x)
			//{
			//	return x > 0;
			//}

			#endregion



			//int string bool 

			//string userName = "dsd";




			User user = new();
			user.Name = "Giorgi";
			user.Surname = "Giorgadze";

			user.PrintInfo();

			User.Saxeli();


		}


		#region hw 2

		//static bool IsEven(int x )
		//{ 

		//   return x % 2 == 0;

		//}




		//static bool IsPrime(int x)
		//{
		//	for(int i =2; i < x; i++)
		//	{
		//		if(x % i == 0)
		//		{
		//			return false;
		//		}
		//	}

		//	return true;
		//}


		//static int CountDigits(int x)
		//{
		//	return x.ToString().Length;
		//}


		//static int ReverseNumber(int x)  // 205   502  
		//{
		//	 string str = x.ToString();
		//	 var array = str.ToCharArray();

		//	Array.Reverse(array);
		//	return int.Parse(array);
		//}

		//		დაწერეთ მეთოდები:
		//•	IsEven — ლუწია თუ კენტი.
		//•	IsPrime — მარტივია თუ არა.
		//•	CountDigits — რამდენი ციფრისგან შედგება.
		//•	ReverseNumber — რიცხვის ციფრების შებრუნება.
		//•	ლოკალური ფუნქცია IsPositive — დადებითობის შემოწმება.

		#endregion

		#region hw 1
		//static double CalculateAverage(int p1, int p2, int p3) 
		//{
		//	return (p1 + p2 + p3) / 3;
		//}

		//static string GetGrade(int x) 
		//{
		//	if (x >= 90)
		//	{
		//		return "A";
		//	}
		//	else if (x >= 80)
		//	{
		//		return "B";
		//	}
		//	else if (x >= 70)
		//	{
		//		return "C";
		//	}
		//	else if (x >= 60)
		//	{
		//		return "D";
		//	}
		//	else
		//	{
		//		return "F";
		//	}
		//}


		//static bool IsPassed(int x)
		//{
		//	return x >= 51;
		//}




		//		•	CalculateAverage — საშუალო ქულის გამოთვლა.
		//•	GetGrade — ქულის მიხედვით შეფასების დაბრუნება.
		//•	IsPassed — განსაზღვრა, ჩააბარა თუ არა სტუდენტმა.
		//•	IsValidScore — ლოკალური ფუნქცია, რომელიც ამოწმებს, ქულა დასაშვებ დიაპაზონშია თუ არა.


		//static void PrintHello()
		//{
		//	Console.WriteLine("Hello World");
		//}


		#endregion
	}




}
