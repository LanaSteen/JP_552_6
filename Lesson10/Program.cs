using Lesson10.Models.Accounts;
using Lesson10.Models.Game;
using Lesson10.Models.Hospital;

namespace Lesson10
{
	internal class Program
	{
		static void Main(string[] args)
		{
//			შექმენით შემდეგი კლასები: CurrentAccount, DepositAccount და CreditAccount.სამივე კლასს უნდა ჰქონდეს ანგარიშის ნომერი და ბალანსი
//დამატებით DepositAccount - ს და CreditAccount -ს უნდა ჰქონდეს  ბარათის ნომერი და ბარათის ვადის გასვლის თარიღი.
//CurrentAccount - ს ბარათი არ აქვს მაგრამ დამატებით აქვს OverdraftLimit.
//აუცილებელია გამოიყენოთ მემკვიდრეობა სწორად/ ოპტიმალურად.
//ასევე აუცილებელია გამოიყენოთ ინკაფსულაცია :
//•	OverdraftLimit უნდა იყოს ინკაფსულირებული. მისი მნიშვნელობა არ უნდა იყოს უარყოფითი და ცვლილება უნდა ხდებოდეს მხოლოდ ვალიდაციის გავლით.
//•	ანგარიშის ნომრის სიგრძე უნდა იყოს 22.
//•	ბალანსი არ შეიძლება იყოს უარყოფითი რიცხვი.
//•	ბარათის ნომერი უნდა იყოს მაქსიმუმ 16 ციფრი.



			/// სახელი 
			/// გვარი
			/// სპეციალობა
			 
			// hasTools

			// ქირურგი
			// კარგიოლოგი

			// ნერვოლოგი


			//Patient 
			//	 სახელი
			//	 გვარი
			//	 ასაკი


			Doctor doctor = new Doctor
			{
				Name = "John",
				Surname = "Doe",
				Specialization = Specialization.Radiologist,
				Pictures = new string[] { "pic1.jpg", "pic2.jpg" },
				Bonuses = new decimal[] { 100.50m, 200.75m },
				Patient = new Patient[]
				{
					new Patient { Name = "Alice", Age = 30 },
					new Patient { Name = "Bob", Age = 25 }
				},
				//Account = new Account { AccountNumber = "Charlie", Balance = 40 }
			};

			Console.WriteLine(doctor);



			//Account accont = new();

			DepositAccount dep = new();

		

		}
	}
}
