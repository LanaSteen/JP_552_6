namespace Lesson14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arrNum = [11, 10, 2, 0, 30];

			arrNum.CustomFirstOrDefault(x => x == 11);
			arrNum.CustomFirstOrDefault(Logic);
			Console.WriteLine(arrNum.CustomFirstOrDefault(isEven));

			Console.WriteLine(arrNum.CustomLastOrDefault(x => x > 10));

			var arr = arrNum.CustomSelect(x => (byte)x);





			//arrNum.CustomFirstOrDefault(delegate (int num)
			//{
			//	return num > 5;
			//});

			arrNum.CustomFirstOrDefault( x=> x > 5);


			bool Logic(int num)
			{
				return num > 5;
			}
			bool Logicgreatethe10(int num)
			{
				return num > 10;
			}

			bool isEven(int num)
			{
				return num % 2 == 0;
			}


			string[] strArr = ["ds@f", "fd@f", "Fdfdf"];

			strArr.CustomCount(x => !x.Contains("@"));

			User[] users = { new User { Name = "John" }, new User { Name = "Jane" } };


			users.ContainsElement(new User { Name = "John" });  /// true


			ArrayHelper.PrintAll(arrNum);

			arrNum.PrintAll();


			ArrayHelper.PrintAll(strArr);
			ArrayHelper.PrintAll(users);
		}



		
		
	}
}
