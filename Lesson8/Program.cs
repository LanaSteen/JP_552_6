namespace Lesson8
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int x = 5;

			Product phone = new();    // {}
			
			phone.Title = "";

			Console.WriteLine(phone.Title);


			//phone._rating
			phone.Rating = 5;



			phone.Description = "SASASAASASAS";
			phone.Price = 1000;
			phone.ConvertToGel();
			phone.Print();

			Console.WriteLine(phone);





			/// name 
			/// age
			/// email
			/// password
			/// phone 
			//ყველა ფროფერთი უნდა გადიოდეს ვალიდაციას


			User user = new User();
			user.Name = "Test";
			user.Age = 5;
			user.Email = "dsdsd@dsdd";
			user.Password = "passwordA1";
			user.Phone = "599599599";


			Console.WriteLine(user);


		}
	}
}
