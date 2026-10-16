namespace Lesson4
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region hw
			//Random random = new Random();

			//int randomNum = random.Next(1, 100);
			//Console.WriteLine("Guess a number between 1 and 100");
			//int userNum = int.Parse(Console.ReadLine());
			//int count = 0;

			//while(randomNum != userNum)
			//{
			//	Console.WriteLine(randomNum>userNum ? "Too low" : "Too high");

			//	Console.WriteLine("Try again");
			//	userNum = int.Parse(Console.ReadLine());
			//	count++;
			//	if(count == 7)
			//	{
			//		Console.WriteLine($"You lose, the number was {randomNum}");
			//		break;
			//	}
			//}
			//Console.WriteLine(randomNum == userNum ? $"You won in {count} tries" : "");




			//bool isValid = int.TryParse(Console.ReadLine(), out int studentCount);
			//int passed = 0;

			//if (isValid)
			//{
			//	for (int i = 0; i < studentCount; i++)
			//	{

			//		bool validScore = int.TryParse(Console.ReadLine(), out int studentScore);

			//		if (validScore)
			//		{
			//			if(studentScore >=90 && studentScore <= 100)
			//			{
			//				Console.WriteLine("A");

			//				passed++;
			//			}
			//			else if(studentScore >= 80 )
			//			{
			//				Console.WriteLine("B"); passed++;
			//			}

			//			else if (studentScore >= 70 )
			//			{
			//				Console.WriteLine("C"); passed++;
			//			}
			//			else if (studentScore >= 60 )
			//			{
			//				Console.WriteLine("D");
			//			}
			//			else
			//			{
			//				Console.WriteLine("F");
			//			}

			//		}



			//	}
			//}




			//Console.WriteLine($"Passed {passed} out of {studentCount} and failed {studentCount - passed}");



			#endregion




			//მასივი    კოლექცია
			//
			//int x = 5;

			////int[] numbers = [50, 0, 30];
			//int[] numbers = { 50, 0, 30,50,60,30,20,40,50,603,30,60,50 };

			//Console.WriteLine(numbers[0]);
			//Console.WriteLine(numbers[numbers.Length-1]);


			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			//for (int i = numbers.Length - 1; i >= 0; i--)
			//{
			//	Console.WriteLine(numbers[i]);
			//}


			//for (int i = 0; i < numbers.Length /2; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			//int[] numbers2 = { 50, 0, 30, 50, 60, 30, 20, 40, 50, 603, 30, 60, 50 };
			//for (int i = 0; i < numbers.Length; i+=2)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			//დაბეჭდეთ ყველა ლუწი ელემენტი რომელიც დგას კენტ ინდექსზე


			//string name = "dsd";

			//Console.WriteLine(name.Length);


			//string[] sdfgfhghb = ["", ""];
			//სტრინგების მასივიდან დაბეჭდეთ მხოლოდ ის სახელები რომლების სიგრძეც არის 5 ზე მეტი


			//string[] names = ["dfg", "Gfgfgffg", "Fdfdf"];

			//for (int i = 0; i < names.Length; i++)
			//{
			//	string el = names[i];
			//	Console.WriteLine(el.Length > 5 ? el : "");
			//}

			//string[] names = ["dfg", "Gfgfgffg", "Fdfdf"];

			//Console.WriteLine(names[1][1]);
			////iterator
			//for (int i = 0; i < names.Length; i++)
			//{
			//	Console.WriteLine(names[i]);  // "dfg"
			//	string name = names[i];

			//	for (int j = 0; j < name.Length; j++)
			//	{
			//		Console.WriteLine(name[j]);
			//	}

			//}
			//
			//2D array
			//jagged  Array
			//	int[][] nummbers = 
			//		[
			//			[20,30,60,50],
			//			[10,20,30],
			//			[10,50,30]
			//		];
			//	int sum = 0;

			//	for (int i = 0; i < nummbers.Length; i++)
			//	{
			//		int[] yuti = nummbers[i];  //[10,20,30],,
			//		int yutiSum = 0;

			//		for (int j = 0; j < yuti.Length; j++)
			//		{
			//			//Console.WriteLine(yuti[j]);
			//			sum += yuti[j];
			//			yutiSum+= yuti[j];
			//		}
			//		Console.WriteLine(yutiSum);
			//	}
			//	Console.WriteLine(sum);










		}


	}
}
