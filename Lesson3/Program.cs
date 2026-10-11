using System.Text;

namespace Lesson3
{
	internal class Program
	{
		static void Main(string[] args)
		{


			Console.OutputEncoding = Encoding.UTF8;	
			Console.InputEncoding = Encoding.UTF8;


			#region hw


			//	დაწერეთ C# Sharp პროგრამა, რომლითაც მომხმარებელი შეიყვანს
			//	ამომრჩევლის ასაკს და პროგრამა
			//განსაზღვრავს, აქვს თუ არა მას არჩევნებზე ხმის მიცემის უფლება.
			//შესაყვანი სატესტო მონაცემი: 18
			// მოსალოდნელი შედეგი: გილოცავ! ხმის მიცემის უფლება გაქვთ.
			//–––––––––––––––––––––––
			//შესაყვანი სატესტო მონაცემი: 15
			//მოსალოდნელი შედეგი: სამწუხაროდ ხმის მიცემის უფლება ჯერ არ გაქვთ.



			//Console.WriteLine("Enter your age");
			//bool isValid = int.TryParse(Console.ReadLine(), out int age);

			//if (age > 18)
			//{
			//	Console.WriteLine("You can vote");
			//}
			//else if (!isValid)
			//{
			//	Console.WriteLine("Invalid input");
			//}
			//else
			//{

			//	Console.WriteLine("you cant vote");
			//}



			//			დაწერეთ C# პროგრამა, რომელიც დაადგენს სამ რიცხვს შორის უდიდესს.
			//შესაყვანი სატესტო მონაცემი:
			//			შეიყვანეთ პირველი რიცხვი: 25
			//შეიყვანეთ მე-2 რიცხვი: 63
			//შეიყვანეთ მე-3 რიცხვი: 10

			//Console.WriteLine("Enyter first number : ");
			//bool isFirstValid = int.TryParse(Console.ReadLine(), out int first);



			//Console.WriteLine("Enyter second number : ");
			//bool isSecondValid = int.TryParse(Console.ReadLine(), out int second);


			//Console.WriteLine("Enyter third number : ");
			//bool isThirdValid = int.TryParse(Console.ReadLine(), out int third);

			//if(isFirstValid && isSecondValid && isThirdValid)
			//{
			//	if(first > second && first > third)
			//	{
			//		Console.WriteLine($"First number is greatest -  {first}");
			//	}else if(second > first && second > third)
			//	{
			//		Console.WriteLine($"Second number is greatest -  {second}");
			//	}
			//	else if (third > first && third > second)
			//	{
			//		Console.WriteLine($"Third number is greatest -  {third}");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("one of them is invalid number");
			//}





			//			დაწერეთ C# პროგრამა ორი მოცემული მთელი რიცხვის ჯამის გამოსათვლელად.
			//			თუ ეს ორი რიცხვი
			//ერთნაირია, მაშინ დააბრუნეთ გასამმაგებული მათი ჯამი.
			// შეყვანის ნიმუში:
			// 1, 2
			// 3, 2
			// 2, 2
			// მოსალოდნელი შედეგი:
			// 3
			// 5
			// 12

			//int x = int.Parse(Console.ReadLine());

			//Console.WriteLine("Enter first number");

			//bool isFirstValid = int.TryParse(Console.ReadLine(), out int first);

			//Console.WriteLine("Enter second number");

			//bool isSecondValid = int.TryParse(Console.ReadLine(), out int second);

			//if (!isFirstValid || !isSecondValid)
			//{
			//	Console.WriteLine("ინვალიდ ინფუთი");
			//}
			//else if (first != second)
			//{
			//	Console.WriteLine(first + second);
			//}
			//else
			//{
			//	Console.WriteLine((first + second) * 3);
			//}







			#endregion


			int x = 30;

			//if (x == 20)
			//{
			//	Console.WriteLine();
			//}
			//else if (x == 30)
			//{
			//	Console.WriteLine();
			//}
			//else if(x == 10)
			//{
			//	Console.WriteLine();
			//}
			//else
			//{
			//	Console.WriteLine();
			//}



			//switch (x)
			//{
			//	case 20:
			//		Console.WriteLine("print from case 20");
			//		break;
			//	case 30:
			//		Console.WriteLine("imushavebs");
			//		return;
			//	case 10:
			//		Console.WriteLine("print from case 10");
			//		goto case 20;

			//	default:
			//		break;
			//}


			//Console.WriteLine("dsfdgfhgjhkgjk");





			//for (int i = 0; i < 10; i+=10)
			//{
			//	Console.WriteLine(i);
			//}

			//for (int i = 10 - 1; i >= 0; i--)
			//{
			//	Console.WriteLine(i);
			//}



			//while (5==5)
			//{
			//	Console.WriteLine("dsfdfgfhgjhj");
			//}


			//int z = 5;
			//int y = z;  // 5


			//z = 10;
			//// y  5
			////
			//int[] arr = [20, 30, 60];
			//int[] arr2 = arr;

			//arr[0] = 100;



			//int num = 10;

			//while (num > 10)
			//{
			//	Console.WriteLine("metia");
			//	num++;
			//}


			//do
			//{
			//	Console.WriteLine("metia");
			//	num++;
			//}
			//while (num > 10);



			//int[] numbers = [20, 30, 60];

			//foreach (var item in numbers)
			//{
			//	Console.WriteLine(item);
			//}


			//foreach (var item in args)
			//{
				
			//}




			

			Random random = new Random();

			Console.WriteLine(random.Next(0,100));





			/// random int

		}
	}
}
